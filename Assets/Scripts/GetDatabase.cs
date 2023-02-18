using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Nova;
using System.IO;
using UnityEngine.WSA;
using static UnityEditor.UIElements.ToolbarMenu;
using Unity.VisualScripting;

public class GetDatabase : MonoBehaviour
{

    [SerializeField]
    TMP_Text HVACName;
    [SerializeField]
    TMP_Text HVACUtilType;
    [SerializeField]
    TMP_Text HVACPrereq;
    [SerializeField]
    TMP_Text HVACDescription;
    [SerializeField]
    TMP_Text HVACPros;
    [SerializeField]
    TMP_Text HVACCons;
    [SerializeField]
    TMP_Text HVACCost;
    public UIBlock2D block;
    string folderPath;
    string fileImage;


    public void GetHVACSystem(string HVACName)
    {
        ImageLoader(HVACName);
        //ClimateControlComponent unit = new ClimateControlComponent("Window AC Unit", "Description", "Pros", "Cons", new string[] { "string1", "string2" }, false, false, false, false, 0.0f, 0.0f, 0.0f, 0.0f,
        //            ClimateControlComponentTypes.Heater, UtilityType.Electric);
        ClimateControlComponent unit = new ClimateControlComponent("Generic AC", "description", "pros", "cons", new ClimateControlComponentTypes[0], false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric);
        DisplayUnit(unit);
    }

    public void ImageLoader(string fileName)
    {

        ////Create an array of file paths from which to choose
        folderPath = UnityEngine.Application.streamingAssetsPath + $"/HVACSystems/";  //Get path of folder
        fileImage = folderPath + "/" + fileName + ".png";
        //Converts desired path into byte array
        byte[] pngBytes = System.IO.File.ReadAllBytes(fileImage);

        //Creates texture and loads byte array data to create image
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(pngBytes);

        //Assigns the UI sprite
        //myNameImage.sprite = fromTex;
        block.SetImage(tex);
    }

    public void DisplayUnit(ClimateControlComponent unit)
    {
        HVACName.text = unit.Name;
        HVACUtilType.text = unit.UtilityType.ToString();
        //HVACPrereq.text = string.Join(", ", unit.PrerequisiteComponents);
        HVACCost.text = "0";
        HVACDescription.text = unit.Description;
        HVACPros.text = unit.Pros;
        HVACCons.text = unit.Cons;
    }
}
