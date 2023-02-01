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
        [SerializeField]
        TMP_Text responseText;
        [SerializeField]
        TMP_Text houseSize;
        int x = 0;

        string folderPath;
        string[] filePaths;
        int index = -1;

        int fileSize;
        int floor = 1;
        int bedroom = 1;
        int bathroom = 1;

        public void HouseSelectionConfirm()
        {

            Debug.Log(floor);
            Debug.Log(bedroom);
            Debug.Log(bathroom);
            Debug.Log(houseSize.text);
            responseText.text = "";

            if (floor == 1 && bedroom == 1 && bathroom == 2)
            {
                responseText.text = "Option not available.";
                return;
            }
            if(floor == 2 && bedroom == 1 && bathroom == 2)
            {
                responseText.text = "Option not available.";
                return;
            }
            if (!int.TryParse(houseSize.text, out x))
            {
                Debug.Log("Inside of tryparse");
                responseText.text = "House size must be a whole number.";
                return;
            }
            
            index = -1;
            getImageFile($"{floor}floor{bedroom}bed{bathroom}bath");
            
        }

        public void FloorSelect()
        {
            floor = Dropdown.selectedIndex + 1;
       
            
        }
        public void BedroomSelect()
        {
            bedroom = Dropdown.selectedIndex + 1;
        }
        public void BathroomSelect()
        {
            bathroom = Dropdown.selectedIndex + 1;
        }

        public void RightClick()
        {
            
            index += 1;
            Debug.Log(index);
            if (index >= fileSize - 1)
            {
                index = fileSize - 1;
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
            Debug.Log(index);
            if (index >= fileSize - 1)
            {
                index = fileSize - 1;
            }
            if (index < 0)
            {
                index = 0;
            }

            ImageLoader(index);
        }
        public int getImageFile(string folder)
        {
            //Create an array of file paths from which to choose
            folderPath = Application.streamingAssetsPath + $"/image/{folder}/";  //Get path of folder
            filePaths = Directory.GetFiles(folderPath, "*.jpg"); // Get all files of type .png in this folder
            fileSize = filePaths.Length;
            return fileSize;
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