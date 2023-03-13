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
        panels = new List<GameObject>();

        panels.Add(controlsPanel);
        panels.Add(savePanel);
        panels.Add(loadPanel);
        panels.Add(detailsPanel);

        activePanel = controlsPanel;
    }

    public void Save()
    {
        activePanel = savePanel;
        SetActivePanel();
    }

    public void Load()
    {
        activePanel = loadPanel;
        SetActivePanel();
    }

    public void Close()
    {
        activePanel = controlsPanel;
        SetActivePanel();
    }

    public void DetailDisplay()
    {
        activePanel = detailsPanel;
        SetActivePanel();
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
