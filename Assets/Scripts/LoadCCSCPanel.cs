using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCCSCPanel : MonoBehaviour
{
    [SerializeField] GameObject loadSavedConfigRowPrefab;
    [SerializeField] GameObject instantiateLocation;
    public List<ClimateControlSystemConfig> climateControlSystemConfigs;
    [SerializeField] GameObject loadingBlock;
    FirebaseDataController firebaseDataController;

    private void Awake()
    {
        firebaseDataController = FindObjectOfType<FirebaseDataController>();
        if (firebaseDataController == null)
        {
            Debug.LogError("FirebaseDataController is null");
        }
    }
    private void OnEnable()
    {
        StartCoroutine(LoadConfigsCoroutine());
    }

    private IEnumerator LoadConfigsCoroutine()
    {
        Transform[] transforms = instantiateLocation.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject != instantiateLocation)
                Destroy(t.gameObject);
        }
        climateControlSystemConfigs.Clear();
        AsyncRequestHelper helper = new();
        loadingBlock.SetActive(true);
        firebaseDataController.AddSystemsToList(climateControlSystemConfigs, helper);

        while (helper.isProcessing)
        {
            yield return null;
        }


        foreach (ClimateControlSystemConfig item in climateControlSystemConfigs)
        {
            GameObject row = Instantiate(loadSavedConfigRowPrefab, instantiateLocation.transform);
            SaveLoadHelper saveLoad = row.GetComponent<SaveLoadHelper>();
            saveLoad.climateControlSystemConfig = item;
            saveLoad.saveName.Text = item.name;
        }

        loadingBlock.SetActive(false);

    }

    private void OnDisable()
    {
        loadingBlock.SetActive(false);
        climateControlSystemConfigs.Clear();
    }
}
