using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Nova;
using System.IO;

public class HouseController : MonoBehaviour
{

    public Image myNameImage;

    string folderPath;
    string[] filePaths;

    private void Awake()
    {
  
        ImageLoader(0);
    }
    public void RightClick()
    {
        ImageLoader(1);
    }

    public void ImageLoader(int n)
    {
        //Create an array of file paths from which to choose
        folderPath = Application.streamingAssetsPath + "/image/";  //Get path of folder
        filePaths = Directory.GetFiles(folderPath, "*.jpg"); // Get all files of type .png in this folder

        //Converts desired path into byte array
        byte[] pngBytes = System.IO.File.ReadAllBytes(filePaths[n]);

        //Creates texture and loads byte array data to create image
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(pngBytes);

        //Creates a new Sprite based on the Texture2D
        Sprite fromTex = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);

        //Assigns the UI sprite
        myNameImage.sprite = fromTex;
    }

}
