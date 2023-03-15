using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Storage;
using Nova;
using UnityEngine;

public class ImageLoader : MonoBehaviour
{

    FirebaseStorage storage;
    StorageReference storageReference;
    FirebaseAuth auth;

    List<byte[]> totalImagesSave = new List<byte[]>();
    List<Task<byte[]>> firebaseImages = new();

    public UIBlock2D imageBlock;
    public UIBlock2D singleImage;
    UIBlock2D prefab;
    public List<Texture2D> imageTextures = new List<Texture2D>();

    public bool isLoadingImages = false;

    public void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
        storage = FirebaseStorage.DefaultInstance;
        storageReference = storage.GetReferenceFromUrl("gs://cscd488-f516a.appspot.com");
    }

    //debug method only
    public void StartLoadImage()
    {
        List<string> testList = new();
        testList.Add("0d75318c-1d8c-4b5c-ba46-9eb805414a4c");
        testList.Add("5dce82ec-cea5-4079-b18b-196b5d6c2c9c");
        testList.Add("71fea48e-8d61-4f7c-aae5-dd0a1d13eca0");

        LoadAllImages(testList);
    }

    //debug method only
    public async void LoadAllImages(List<string> images)
    {
        totalImagesSave = await GetAllImages(images);
        foreach (var imageByte in totalImagesSave)
        {
            prefab = Instantiate(singleImage, imageBlock.transform);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(imageByte);
            prefab.SetImage(tex);
        }
    }

    public async void LoadAllTextures(List<string> images)
    {
        isLoadingImages = true;
        ClearCurrentInfo();
        totalImagesSave = await GetAllImages(images);
        foreach (var imageByte in totalImagesSave)
        {
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(imageByte);
            imageTextures.Add(tex);
        }
        isLoadingImages = false;
    }

    private void ClearCurrentInfo()
    {
        imageTextures.Clear();
        totalImagesSave.Clear();
        imageTextures.Clear();
    }

    public async Task<List<byte[]>> GetAllImages(List<string> imageNames)
    {
        foreach (string guid in imageNames)
        {
            firebaseImages.Add(GetImage(guid));
        }
        totalImagesSave = (await Task.WhenAll(firebaseImages)).ToList();
        return totalImagesSave.Where(x => x is not null).ToList();
    }

    public async Task<byte[]> GetImage(string guid)
    {
        try
        {
            const long maxAllowedSize = 5 * 1024 * 1024;
            StorageReference image = storageReference.Child($"/{auth.CurrentUser.UserId}/{guid}");
            return await image.GetBytesAsync(maxAllowedSize);
        }
        catch (Exception)
        {
            return null;
        }
    }
}
