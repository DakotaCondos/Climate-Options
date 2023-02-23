using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaButtonBehavior : MonoBehaviour
{
    private UIBlock2D self;
    private void Awake()
    {
        TryGetComponent<UIBlock2D>(out self);
        if (self == null) throw new MissingComponentException("Missing UIBlock2D");
    }

    public void SetBorderVisibility(bool value)
    {
        self.Border.Enabled = value;
    }
}
