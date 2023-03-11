using System.Collections;
using System.Collections.Generic;
using Nova;
using UnityEngine;

public class HouseImageController : MonoBehaviour
{

    public UIBlock2D imageBlock;
    List<byte[]> totalImagesSave = new List<byte[]>();
    int imageIndex;
    int totalImagesIndex;


    HouseSceneController houseSceneController;
    FirebaseStorageController firebaseStorageController;

    public void Start()
    {
        houseSceneController = FindObjectOfType<HouseSceneController>();
        firebaseStorageController = FindObjectOfType<FirebaseStorageController>();
    }

    public async void DisplayAllImages()
    {
        houseSceneController.CurrentPanel(3);
        totalImagesSave = await firebaseStorageController.GetAllImages();
        print("---totalImageSaveCount in DisplayAllimages()---" + totalImagesSave.Count);
        totalImagesIndex = firebaseStorageController.GetTotalImageIndex();

        if (totalImagesSave.Count > 0)
        {
            StartCoroutine(FadeImage(false));
            ImageLoader(0);
        } 
    }

    public void ImageLoader(int index)
    {
        byte[] jpgBytes = totalImagesSave[index];
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(jpgBytes);
        imageBlock.SetImage(tex);
    }

    public IEnumerator FadeImage(bool fadeAway)
    {
        if (fadeAway)
        {
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                imageBlock.Color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        else
        {
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                imageBlock.Color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }

    public void RightClick()
    {

        imageIndex += 1;
        Debug.Log(imageIndex);
        if (imageIndex >= totalImagesIndex - 1)
        {
            imageIndex = totalImagesIndex - 1;
        }
        if (imageIndex < 0)
        {
            imageIndex = 0;
        }
        ImageLoader(imageIndex);
    }

    public void LeftClick()
    {
        imageIndex -= 1;
        Debug.Log(imageIndex);
        if (imageIndex >= totalImagesIndex - 1)
        {
            imageIndex = totalImagesIndex - 1;
        }
        if (imageIndex < 0)
        {
            imageIndex = 0;
        }
        ImageLoader(imageIndex);
    }
}
