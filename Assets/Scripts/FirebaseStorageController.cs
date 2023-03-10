using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Extensions;
using Firebase.Storage;
using Nova;
using SimpleFileBrowser;
using System.Threading.Tasks;
using System;
using System.Linq;
using TMPro;

public class FirebaseStorageController : MonoBehaviour
{
    //public UIBlock2D imageBlock;
    FirebaseStorage storage;
    StorageReference storageReference;

    HouseSceneController houseSceneController;

    public UIBlock2D successfulUpload;
    public UIBlock2D progressPanel;
    UIBlock2D prefab;

    List<Task<byte[]>> firebaseImages = new();
    List<byte[]> totalImagesSave;
    int imageIndex;

    int totalImagesIndex = 0;

    private void Start()
    {
        houseSceneController = FindObjectOfType<HouseSceneController>();
        storage = FirebaseStorage.DefaultInstance;
        storageReference = storage.GetReferenceFromUrl("gs://cscd488-f516a.appspot.com");

        FileBrowser.SetFilters(false, new FileBrowser.Filter("Images", ".jpg", ".png", ".jpeg"));

        //FileBrowser.SetDefaultFilter(".jpg");

        FileBrowser.SetExcludedExtensions(".lnk", ".tmp", ".zip", ".rar", ".exe");

        FileBrowser.AddQuickLink("Users", "C:\\Users", null);

    }
    public void SwitchToImageUploadPanel()
    {
        houseSceneController.CurrentPanel(2);

    }
    public void ClickUploadButton()
    {
        StartCoroutine(ShowLoadDialogCoroutine());
    }


    public IEnumerator ShowLoadDialogCoroutine()
    {
        yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.Files, false, null, null, "Load Files", "Load");
        Debug.Log(FileBrowser.Success);

        if (FileBrowser.Success)
        {
            for (int i = 0; i < FileBrowser.Result.Length; i++)
            {
                Debug.Log("FILESS: " + FileBrowser.Result[i]);
            }

            byte[] bytes = FileBrowserHelpers.ReadBytesFromFile(FileBrowser.Result[0]);
            var newMetaData = new MetadataChange
            {
                ContentType = "image/jpeg"
            };
            var fileName = FileBrowserHelpers.GetFilename(FileBrowser.Result[0]);
            SaveImage(bytes, newMetaData, fileName);
        }
    }

    //public async void Test()
    //{
    //    await GetAllImages();
    //    print("TOTAL COUNT: " + totalImagesIndex);
    //    print("FirebaseImage Count: " + firebaseImages.Count);
    //    print("REsult list Count: " + totalImagesSave.Count);
    //    Texture2D tex = new Texture2D(2, 2);
    //    tex.LoadImage(totalImagesSave[0]);
    //    imageBlock.SetImage(tex);


    //}

    //public void ImageLoader(int index)
    //{
    //    byte[] jpgBytes = totalImagesSave[index];
    //    Texture2D tex = new Texture2D(2, 2);
    //    tex.LoadImage(jpgBytes);
    //    imageBlock.SetImage(tex);
    //}

    public async Task<List<byte[]>> GetAllImages()
    {
        
        print("Before for loop: " + totalImagesIndex);
        for(int i = 0; i < totalImagesIndex; i++)
        {
            var task = GetImage(i);
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.LogException(task.Exception);
            }
            else
            {
                print("Inside of GetAllImages Else");
                firebaseImages.Add(GetImage(i));
                
            }
        }
        totalImagesSave = (await Task.WhenAll(firebaseImages)).ToList(); ;
        print("Test FirebaseCountL " + totalImagesSave.Count);
        return totalImagesSave;
    }

    public Task<byte[]> GetImage(int i)
    {
        const long maxAllowedSize = 1 * 1024 * 1024;
        StorageReference image = storageReference.Child($"/uploads/{i}");
        return image.GetBytesAsync(maxAllowedSize);
    }


    public void SaveImage(byte[] bytes, MetadataChange metadataChange, string fileName)
    {
        StorageReference uploadReference = storageReference.Child($"uploads/{totalImagesIndex}");
        uploadReference.PutBytesAsync(bytes, metadataChange).ContinueWithOnMainThread((Action<Task<StorageMetadata>>)((task) =>
        {
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.Log(task.Exception.ToString());
            }
            else
            {
                Debug.Log("File uploaded successfully!");
                print("Filename: " + fileName);
                prefab = Instantiate(successfulUpload, progressPanel.transform);
                TMP_Text textBlock = prefab.GetComponentInChildren<TMP_Text>();
                textBlock.text = fileName;
                print(textBlock.text);
                totalImagesIndex++;
            }
        }));
    }

    public int GetTotalImageIndex()
    {
        return totalImagesIndex;
    }   

    //public IEnumerator FadeImage(bool fadeAway)
    //{
    //    if (fadeAway)
    //    {
    //        for (float i = 1; i >= 0; i -= Time.deltaTime)
    //        {
    //            imageBlock.Color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //    else
    //    {
    //        for (float i = 0; i <= 1; i += Time.deltaTime)
    //        {
    //            imageBlock.Color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }  
    //}

    //public void RightClick()
    //{

    //    imageIndex += 1;
    //    Debug.Log(imageIndex);
    //    if (imageIndex >= totalImagesIndex - 1)
    //    {
    //        imageIndex = totalImagesIndex - 1;
    //    }
    //    if (imageIndex < 0)
    //    {
    //        imageIndex = 0;
    //    }
    //    ImageLoader(imageIndex);
    //}

    //public void LeftClick()
    //{
    //    imageIndex -= 1;
    //    Debug.Log(imageIndex);
    //    if (imageIndex >= totalImagesIndex - 1)
    //    {
    //        imageIndex = totalImagesIndex - 1;
    //    }
    //    if (imageIndex < 0)
    //    {
    //        imageIndex = 0;
    //    }
    //    ImageLoader(imageIndex);
    //}
}




