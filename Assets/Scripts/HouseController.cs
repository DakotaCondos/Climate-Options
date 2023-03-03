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
        int index;
        string folderPath;
        string[] filePaths;

        int fileSize;
        int bedroom;
        int bathroom;
        HouseConfig houseConfig;

        public void HouseSelectionConfirm()
        {
            Debug.Log(bedroom);
            Debug.Log(bathroom);
            responseText.text = "";

            if (bathroom > bedroom)
            {
                responseText.text = "Bathroom cannot exceed bedrooms. Please try again.";
                block.ClearImage();
                return;
            }

            index = 0;
            getImageFile($"{bedroom + 1}bed{bathroom + 1}bath");
            StartCoroutine(FadeImage(false));
            ImageLoader(index);

            houseConfig = CreateHouseConfig();
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

            byte[] pngBytes = System.IO.File.ReadAllBytes(filePaths[n]);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(pngBytes);
            block.SetImage(tex);
        }

        public IEnumerator FadeImage(bool fadeAway)
        {
            // fade from opaque to transparent
            if (fadeAway)
            {
                // loop over 1 second backwards
                for (float i = 1; i >= 0; i -= Time.deltaTime)
                {
                    // set color with i as alpha
                    block.Color = new Color(1, 1, 1, i);
                    yield return null;
                }
            }
            // fade from transparent to opaque
            else
            {
                // loop over 1 second
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    // set color with i as alpha
                    block.Color = new Color(1, 1, 1, i);
                    yield return null;
                }
            }
        }
    }
}