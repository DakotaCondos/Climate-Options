using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOverlayControls : MonoBehaviour
{
    ProgramManager programManager;
    ConfigurationDetailsController configurationDetailsController;

    public GameObject controlsPanel;
    public GameObject savePanel;
    public GameObject loadPanel;
    public GameObject detailsPanel;
    public GameObject exitButton;

    private List<GameObject> panels;

    public GameObject activePanel;

    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
        configurationDetailsController = FindObjectOfType<ConfigurationDetailsController>();
        panels = new List<GameObject>
        {
            controlsPanel,
            savePanel,
            loadPanel
        };
        detailsPanel.SetActive(true);
        ClosePanel();
    }

    public void ClosePanel()
    {
        activePanel = controlsPanel;
        SetActivePanel();
    }
    public void SavePanel()
    {
        activePanel = savePanel;
        SetActivePanel();
    }

    public void LoadPanel()
    {
        activePanel = loadPanel;
        SetActivePanel();
    }

    public void DetailDisplayPanel(ClimateControlSystemConfig climateControlSystemConfig)
    {
        activePanel = detailsPanel;
        SetActivePanel();
        configurationDetailsController.InitailizeDisplay(configurationDetailsController.configurationDetailsDisplays[1], climateControlSystemConfig);
    }

    private void SetActivePanel()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(activePanel == panel);
        }
        exitButton.SetActive(activePanel != controlsPanel);
    }

}
