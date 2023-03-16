#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEngine;
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
        HouseSceneController houseSceneController;

        int fileSize;
        int bedroom;
        int bathroom;
        public HouseConfig houseConfig;

        public void Awake()
        {
            houseSceneController = FindObjectOfType<HouseSceneController>();
        }
        public void Start()
        {
            houseSceneController.CurrentPanel(0);
        }
        public void HouseSelectionConfirm()
        {
            responseText.text = "";

            if (!HouseSizeValidate(houseSize))
            {
                return;
            }

            houseConfig = CreateHouseConfig();
            houseSceneController.CurrentPanel(1);


        }

        public HouseConfig CreateHouseConfig()
        {
            HouseConfig houseConfig = new HouseConfig();
            List<RoomConfig> rooms = new();
            int totalRooms = bedroom + bathroom + 1;

            for (int i = 0; i <= totalRooms; i++)
            {
                if (i <= bedroom)
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
            //bedroom = Dropdown.selectedIndex;
        }
        public void BathroomSelect()
        {
            //bathroom = Dropdown.selectedIndex;
        }

        public bool HouseSizeValidate(TMP_Text houseSize)
        {
            if (string.IsNullOrWhiteSpace(houseSize.text))
            {
                responseText.text = "House size required";
                return false;
            }
            if (!int.TryParse(houseSize.text, out houseSizeToInt))
            {
                responseText.text = "House size must be a whole number.";
                return false;
            }
            if (int.Parse(houseSize.text) <= 0)
            {
                responseText.text = "House size cannot be less than 0.";
                return false;
            }
            return true;
        }
    }
}
// current file contents
#endif