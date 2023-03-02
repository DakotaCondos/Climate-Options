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
        int index = 0;
        string folderPath;
        string[] filePaths;

        int fileSize;
        int bedroom;
        int bathroom;

        public void HouseSelectionConfirm()
        {

            Debug.Log(bedroom);
            Debug.Log(bathroom);
            responseText.text = "";

            if (bathroom > bedroom)
            {
                responseText.text = "Bathroom cannot exceed bedrooms. Please try again.";
                block.SetImage(Texture2D.blackTexture);
                return;
            }
            
            //getImageFile($"1floor{bedroom}bed{bathroom}bath");
     
            getImageFile($"{bedroom + 1}bed{bathroom + 1}bath");
            ImageLoader(index);
            var houseConfigTest = CreateHouseConfig();
            foreach(RoomConfig rooms in houseConfigTest.rooms)
            {
                print("Room: " + rooms.roomNumber);
                print("Contain bathroom: " + rooms.isBathroom);
            }
            
        }

        public HouseConfig CreateHouseConfig()
        {
            HouseConfig houseConfig = new HouseConfig();
            List<RoomConfig> rooms = new();

            for(int i = 0; i <= bedroom; i++)
            {
                if(i <= bathroom)
                {
                    rooms.Add(new RoomConfig(i, true));
                }
                else
                {
                    rooms.Add(new RoomConfig(i, false));
                }
            }
            houseConfig.rooms = rooms;
            return houseConfig;
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
            if(Directory.Exists(Application.streamingAssetsPath + $"/image/{folder}/"))
            {
                folderPath = Application.streamingAssetsPath + $"/image/{folder}/";
            }
            else
            {
                folderPath = Application.streamingAssetsPath + $"/image/NotAvailable/";
            }
        
            filePaths = Directory.GetFiles(folderPath, "*.jpg"); 
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