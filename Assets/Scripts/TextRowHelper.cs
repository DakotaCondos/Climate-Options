//#if UNITY_EDITOR
using Nova;
using System.Collections.Generic;
using UnityEngine;

public class TextRowHelper : MonoBehaviour, IVisible
{
    public List<TextBlock> textBlocks = new List<TextBlock>();

    public void SetVisible(bool value)
    {
        textBlocks.ForEach(block => { block.Visible = value; });
    }
}
// current file contents
//#endif