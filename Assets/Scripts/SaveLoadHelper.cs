using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadHelper : MonoBehaviour
{
    public ClimateControlSystemConfig ClimateControlSystemConfig;
    public ComparisonOverlayControls ComparisonOverlayControls;

    private void Awake()
    {
        ComparisonOverlayControls = FindObjectOfType<ComparisonOverlayControls>();
    }

    public void Save()
    {

    }

    public void Load()
    {

    }
}
