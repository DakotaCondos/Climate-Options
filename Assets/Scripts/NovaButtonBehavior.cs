//#if UNITY_EDITOR

using Nova;
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

// current file contents
//#endif