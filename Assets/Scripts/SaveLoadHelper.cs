using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadHelper : MonoBehaviour
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public ComparisonOverlayControls comparisonOverlayControls;
    public TextBlock saveName;

    private void Awake()
    {
        comparisonOverlayControls = FindObjectOfType<ComparisonOverlayControls>();
    }

    public void Save()
    {

    }

    public void Load()
    {
        comparisonOverlayControls.DetailDisplayPanel(climateControlSystemConfig);
    }
}
