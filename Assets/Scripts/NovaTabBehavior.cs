using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaTabBehavior : MonoBehaviour
{
    [SerializeField]
    bool isTabParent = false;
    [SerializeField]
    GameObject[] tabHeaders;
    private NovaTabBehavior[] tabHeadersNTB;
    [SerializeField]
    GameObject[] tabBodies;
    public int activeTabIndex = 0;

    [SerializeField]
    GameObject selectedIndicator;

    private void Awake()
    {
        if (!isTabParent) return;

        tabHeadersNTB = new NovaTabBehavior[tabHeaders.Length];
        for (int i = 0; i < tabHeaders.Length; i++)
        {
            tabHeadersNTB[i] = GetNovaTabBehavior(i);
        }

        for (int i = 0; i < tabHeaders.Length; i++)
        {
            SetTabState(i, false);
            DisplayIndexBody(i, false);
        }
        SetTabState(activeTabIndex, true);
        DisplayIndexBody(activeTabIndex, true);
    }

    public void setActiveTab(int tabIndex)
    {
        SetTabState(activeTabIndex, false);
        DisplayIndexBody(activeTabIndex, false);
        activeTabIndex = tabIndex;
        SetTabState(activeTabIndex, true);
        DisplayIndexBody(activeTabIndex, true);
    }

    private void SetTabState(int index, bool value)
    {
        tabHeadersNTB[index].DisplaySelectedIndicator(value);
    }

    public NovaTabBehavior GetNovaTabBehavior(int index)
    {
        NovaTabBehavior tab;
        if (!tabHeaders[index].TryGetComponent<NovaTabBehavior>(out tab))
            throw new MissingReferenceException("Missing NovaTabBehavior GameObject");
        return tab;
    }

    public void DisplaySelectedIndicator(bool value)
    {
        if (selectedIndicator != null)
            selectedIndicator.SetActive(value);
    }

    public void DisplayIndexBody(int index, bool state)
    {
        if (tabBodies[index] != null)
            tabBodies[index].SetActive(state);
    }
}
