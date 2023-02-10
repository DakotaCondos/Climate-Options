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
    HVACDatabase database = new HVACDatabase();

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


    public void GetWindowAC()
    {
        ImageLoader("window-ac-unit");
        GetUnit("Window AC units");
    }
    public void GetPortableAC()
    {
        ImageLoader("portable-air-condition");
        GetUnit("Portable Air Conditioners");
    }

    public void GetDuctlessMiniSplitAC()
    {
        ImageLoader("ductless-mini-split-air-conditioning-systems");
        GetUnit("Ductless Mini Split AC");
    }
    public void GetCentralACSystem()
    {
        ImageLoader("central-air-conditioning-system");
        GetUnit("Central AC System");
    }
    public void GetElectricFurnace()
    {
        ImageLoader("electric-furnace");
        GetUnit("Electric Furnace");
    }
    public void GetGasFurnace()
    {
        ImageLoader("gas-furnace");
        GetUnit("Gas Furnace");
    }
    public void GetOilFurnace()
    {
        ImageLoader("oil furnace");
        GetUnit("Oil Furnace");
    }
    public void GetGasBoiler()
    {
        ImageLoader("gas-boiler");
        GetUnit("Gas Boiler");
    }
    public void GetHeatPump()
    {
        ImageLoader("heat-pump");
        GetUnit("Heat Pump");
    }
    public void GetMicroCombinedHeatandPower()
    {
        ImageLoader("micro-combined-heat-and-power");
        GetUnit("Micro Combined Heat and Power");
    }
    public void GetElectricRadiantFloorHeating()
    {
        ImageLoader("electric-radiant-floor-heating");
        GetUnit("Electric Radiant Floor Heating");
    }
    public void GetGasFiredSpaceHeaters()
    {
        ImageLoader("gas-fired-space-heaters");
        GetUnit("Gas Fired Space Heaters");
    }
    public void GetElectricSpaceHeaters()
    {
        ImageLoader("electric-space-heaters");
        GetUnit("Electric Space Heaters");
    }
    public void GetWoodBurningStoves()
    {
        ImageLoader("wood-burning-stoves");
        GetUnit("Wood Burning Stoves");
    }
    public void GetFireplaces()
    {
        ImageLoader("fireplaces");
        GetUnit("Fireplaces");
    }
    public void GetDuctlessMiniSplitSystem()
    {
        ImageLoader("ductless-mini-split-air-conditioning-systems");
        GetUnit("Ductless Mini Split System");
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

    public void GetUnit(string HVACUnit)
    {
        List<HVACType> ACData = database.findAll();
        HVACType ACUnit = ACData.Find(n => n.Name == HVACUnit);
        Debug.Log(ACUnit.Name);
        HVACName.text = ACUnit.Name;
        HVACUtilType.text = ACUnit.UtilityType;
        HVACPrereq.text = ACUnit.Prerequisites;
        HVACCost.text = ACUnit.ApproximateCost;
        HVACDescription.text = ACUnit.Description;
        HVACPros.text = ACUnit.Pros;
        HVACCons.text = ACUnit.Cons;
    }

}
