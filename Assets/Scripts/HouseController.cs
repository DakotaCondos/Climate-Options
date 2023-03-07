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

        [SerializeField]
        TMP_Text responseText;
        [SerializeField]
        TMP_Text houseSize;

        int houseSizeToInt;
        int index;
        string folderPath;
        string[] filePaths;

        int fileSize;
        int bedroom;
        int bathroom;
        HouseConfig houseConfig;

        ImageLoader imageLoader;

           public void HouseSelectionConfirm()
        {
            Debug.Log(bedroom);
            Debug.Log(bathroom);
            responseText.text = "";
            
            if(!HouseSizeValidate(houseSize))
            {
                return;
            }

            index = 0;
            StartCoroutine(imageLoader.LoadImage("gs://cscd488-f516a.appspot.com/1.jpg"));
            houseConfig = CreateHouseConfig();

            print("House Config Size: " + houseConfig.size);
            foreach(RoomConfig rooms in houseConfig.rooms)
            {
                print("Room: " + rooms.roomNumber);
                print("Contain bathroom: " + rooms.isBathroom);
            }
        }

        public HouseConfig CreateHouseConfig()
        {
            HouseConfig houseConfig = new HouseConfig();
            List<RoomConfig> rooms = new();
            int totalRooms = bedroom + bathroom + 1;

            for(int i = 0; i <= totalRooms; i++)
            {
                if(i <= bedroom)
                {
                    rooms.Add(new RoomConfig(i, false));
                }
                else
                {
                    rooms.Add(new RoomConfig(i, true));
                }
            }
                
            houseConfig.rooms = rooms;
            houseConfig.size = int.Parse(houseSize.text);
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
           
            
        }

        public bool HouseSizeValidate(TMP_Text houseSize)
        {
            if (string.IsNullOrWhiteSpace(houseSize.text))
            {
                responseText.text = "House size required";
                //block.ClearImage();
                return false;
            }
            if (!int.TryParse(houseSize.text, out houseSizeToInt))
            {
                responseText.text = "House size must be a whole number.";
                //block.ClearImage();
                return false;
            }
            if(int.Parse(houseSize.text) <= 0)
            {
                responseText.text = "House size cannot be less than 0.";
                //block.ClearImage();
                return false;
            }

            return true;

        }
    }
}