using Nova;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BorderActiveGroup : MonoBehaviour
{
    public List<UIBlock2D> blocks;

    private void Start()
    {
        SetActiveBorder(blocks.First());
    }

    public void SetActiveBorder(UIBlock2D block)
    {
        foreach (UIBlock2D item in blocks)
        {
            item.Border.Enabled = (item.Equals(block));
        }
    }
}
