//#if UNITY_EDITOR
using Nova;
using UnityEngine;

public class BorderActiveButton : MonoBehaviour
{
    public BorderActiveGroup borderActiveGroup;

    public void Activated()
    {
        borderActiveGroup.SetActiveBorder(gameObject.GetComponent<UIBlock2D>());
    }
}
// current file contents
//#endif