//#if UNITY_EDITOR
using Nova;
using UnityEngine;

public class ComponentController : MonoBehaviour
{

    public void Start()
    {
        ImageLoader("2D-Floor-Plan-Narrow-Bathroom-3");
    }
    public GameObject HVACPanel;
    public GameObject HousePanel;

    public UIBlock2D block;
    //public UIBlock2D livingRoomBlock;
    public UIBlock2D bedroom;

    string folderPath;
    string fileImage;

    public void SwitchShowHide()
    {
        HVACPanel.SetActive(false);
        HousePanel.SetActive(true);
        
    }
    public void BedroomVisual()
    {
        bedroom.Shadow.Enabled = true;
        bedroom.Shadow.Direction = ShadowDirection.In;
        bedroom.Shadow.Color = new Color32(86, 111, 180, 128);
        bedroom.Shadow.Width = 50;
        bedroom.Shadow.Blur = 100;
    }
    public void ImageLoader(string fileName)
    {

        ////Create an array of file paths from which to choose
        folderPath = UnityEngine.Application.streamingAssetsPath + $"/image/1floor1bed1bath/";  //Get path of folder
        fileImage = folderPath + "/" + fileName + ".jpg";
        //Converts desired path into byte array
        byte[] pngBytes = System.IO.File.ReadAllBytes(fileImage);

        //Creates texture and loads byte array data to create image
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(pngBytes);

        //Assigns the UI sprite
        //myNameImage.sprite = fromTex;
        block.SetImage(tex);
    }
}
// current file contents
//#endif