using System.Collections;
using System.Collections.Generic;
using System.IO;
using Firebase.Storage;
using Nova;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using Firebase.Extensions;
using System;

public class ImageLoader : MonoBehaviour
{
    FirebaseStorage storage;
    StorageReference storageReference;
    [SerializeField]
    UIBlock2D block;

    private void Awake()
    {
        storage = FirebaseStorage.DefaultInstance;
        storageReference = storage.GetReferenceFromUrl("gs://bucket/images/stars.jpg");
    }

    public IEnumerator LoadImage(string imageUrl)
    {
        const long maxAllowedSize = 1 * 1024 * 1024;
        StorageReference image = storageReference.Child("1.jpg");
        var getImage = image.GetBytesAsync(maxAllowedSize).ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.LogException(task.Exception);
                // Uh-oh, an error occurred!
            }
            else
            {
                byte[] fileContents = task.Result;
                Texture2D tex = new Texture2D(2, 2);
                tex.LoadImage(fileContents);

                //Assigns the UI sprite
                //myNameImage.sprite = fromTex;
                block.SetImage(tex);
                Debug.Log("Finished downloading!");
            }
        });
        yield return new WaitUntil(() => getImage.IsCompleted);
    }

    //public IEnumerator FadeImage(bool fadeAway)
    //{
    //    // fade from opaque to transparent
    //    if (fadeAway)
    //    {
    //        // loop over 1 second backwards
    //        for (float i = 1; i >= 0; i -= Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            block.Color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //    // fade from transparent to opaque
    //    else
    //    {
    //        // loop over 1 second
    //        for (float i = 0; i <= 1; i += Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            block.Color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //}

}
