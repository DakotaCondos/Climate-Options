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
using Firebase.Auth;

public class FirebaseStorageController : MonoBehaviour
{
    FirebaseStorage storage;
    StorageReference storageReference;
    FirebaseAuth auth;

    HouseSceneController houseSceneController;
    ClimateControlSystemConfig climateControlSystemConfig = new();

    public UIBlock2D successfulUpload;
    public UIBlock2D progressPanel;
    UIBlock2D prefab;

    public TMP_Text maxSizeError;
    List<Task<byte[]>> firebaseImages = new();
    List<byte[]> totalImagesSave = new();
    public List<string> guidValues = new();

    int imageIndex;

    int totalImagesIndex = 0;

    private void Start()
    {
        climateControlSystemConfig.pictureNames = guidValues;
        auth = FirebaseAuth.DefaultInstance;
        houseSceneController = FindObjectOfType<HouseSceneController>();
        storage = FirebaseStorage.DefaultInstance;
        storageReference = storage.GetReferenceFromUrl("gs://cscd488-f516a.appspot.com");

        FileBrowser.SetFilters(false, new FileBrowser.Filter("Images", ".jpg", ".png", ".jpeg"));

        FileBrowser.SetExcludedExtensions(".lnk", ".tmp", ".zip", ".rar", ".exe");

        FileBrowser.AddQuickLink("Users", "C:\\Users", null);

    }
    public void SwitchToImageUploadPanel()
    {
        houseSceneController.CurrentPanel(2);

    }
    public void ClickUploadButton()
    {
        print("imageIndex: " + totalImagesIndex);
        if (totalImagesIndex < 3)
        {
            StartCoroutine(ShowLoadDialogCoroutine());
        }
        else
        {
            maxSizeError.text = "Maximum Limit Upload Reached: 3";
        }
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


    public async Task<List<byte[]>> GetAllImages()
    {
        foreach (string guid in guidValues)
        {
            firebaseImages.Add(GetImage(guid));
        }

        totalImagesSave = (await Task.WhenAll(firebaseImages)).ToList();
        print("Test FirebaseCountL " + totalImagesSave.Count);
        return totalImagesSave.Where(x => x is not null).ToList();
      
        
    }

    public async Task<List<byte[]>> GetAllImages(List<string> imageNames)
    {
        foreach (string guid in imageNames)
        {
            firebaseImages.Add(GetImage(guid));
        }
        totalImagesSave = (await Task.WhenAll(firebaseImages)).ToList();
        print("Test FirebaseCountL " + totalImagesSave.Count);
        return totalImagesSave.Where(x => x is not null).ToList();
    }

    public async Task<byte[]> GetImage(string guid)
    {
        try
        {
            print("GetImage() try block");
            const long maxAllowedSize = 5 * 1024 * 1024;
            StorageReference image = storageReference.Child($"/{auth.CurrentUser.UserId}/{guid}");
            return await image.GetBytesAsync(maxAllowedSize);
        }
        catch (Exception)
        {
            print("Getimage() catch block");
            return null;
        }
    }

    public void SaveImage(byte[] bytes, MetadataChange metadataChange, string fileName)
    {
        Guid guid = Guid.NewGuid();
        StorageReference uploadReference = storageReference.Child($"{auth.CurrentUser.UserId}/{guid}");
        uploadReference.PutBytesAsync(bytes, metadataChange).ContinueWithOnMainThread((Action<Task<StorageMetadata>>)((task) =>
        {
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.Log(task.Exception.ToString());
            }
            else
            {
                Debug.Log("File uploaded successfully!");
                prefab = Instantiate(successfulUpload, progressPanel.transform);
                TMP_Text textBlock = prefab.GetComponentInChildren<TMP_Text>();
                textBlock.text = fileName;
                print(textBlock.text);
                totalImagesIndex++;
                guidValues.Add(guid.ToString());
                foreach (var guid in guidValues)
                {
                    print("Current Guid Values in List: " + guid);
                }
            }
        }));
    }

    public int GetTotalImageIndex()
    {
        return totalImagesIndex;
    }   
}




