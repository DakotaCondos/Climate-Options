using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Nova;
using System.IO;
using TMPro;

namespace NovaSamples.UIControls
{
    public class HouseController : MonoBehaviour
    {
        public UIBlock2D block;

        string folderPath;
        string[] filePaths;
        int index = -1;

        int floor;
        int bedroom;
        int bathroom;

        public void HouseSelectionConfirm()
        {

            Debug.Log(floor);
            Debug.Log(bedroom);
            Debug.Log(bathroom);

            if(floor == 0 && bedroom == 0 && bathroom == 0)
            {
                getImageFile("1floor1bed1bath");
                index = -1;
            }
            if(floor == 1 & bedroom == 0 && bathroom ==0)
            {
                getImageFile("2floor1bed1bath");
                index = -1;
            }
        }

        public void FloorSelect()
        {
            floor = Dropdown.selectedIndex;
        }
        public void BedroomSelect()
        {
            bedroom = Dropdown.selectedIndex;
        }
        public void BathroomSelect()
        {
            bathroom = Dropdown.selectedIndex;
        }

        public void RightClick()
        {
            index += 1;
            if (index >= 2)
            {
                index = 2;
            }
            if (index < 0)
            {
                index = 0;
            }

            ImageLoader(index);
        }

        public void LeftClick()
        {
            index -= 1;
            if (index >= 2)
            {
                index = 2;
            }
            if (index < 0)
            {
                index = 0;
            }

            ImageLoader(index);
        }
        public void getImageFile(string folder)
        {
            //Create an array of file paths from which to choose
            folderPath = Application.streamingAssetsPath + $"/image/{folder}/";  //Get path of folder
            filePaths = Directory.GetFiles(folderPath, "*.jpg"); // Get all files of type .png in this folder
        }
        public void ImageLoader(int n)
        {

            //Converts desired path into byte array
            byte[] pngBytes = System.IO.File.ReadAllBytes(filePaths[n]);

            //Creates texture and loads byte array data to create image
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(pngBytes);

            //Assigns the UI sprite
            //myNameImage.sprite = fromTex;
            block.SetImage(tex);
        }


    }

}