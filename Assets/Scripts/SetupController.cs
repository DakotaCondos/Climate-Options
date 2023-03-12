using Nova;
using NovaSamples.UIControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class SetupController : MonoBehaviour
{
    public bool autoCalculateUtilityRate;
    [SerializeField]
    private GameObject novaToggle;
    [SerializeField]
    private float scaleFadeTime = 0.2f;
    Toggle toggle;

    [SerializeField]
    TMP_Text zipTMP;

    [SerializeField]
    GameObject utilitiesBlock;
    [SerializeField]
    TMP_Text electrictyTMP;
    [SerializeField]
    TMP_Text gasTMP;
    [SerializeField]
    TMP_Text oilTMP;
    [SerializeField]
    TMP_Text woodPelletTMP;

    [SerializeField]
    public TMP_Text responseTextblock;
    private float electric = 0;
    private float gas = 0;
    private float oil = 0;
    private float wood = 0;

    UtilityRatesAndZip utilityRatesAndZip;
    ProgramManager programManager;


    private void Awake()
    {
        toggle = novaToggle.GetComponent<Toggle>();
        UpdateToggle();
        utilityRatesAndZip = FindObjectOfType<UtilityRatesAndZip>();
        programManager = FindObjectOfType<ProgramManager>();
    }

    public void UpdateToggle()
    {
        if (toggle != null)
        {
            autoCalculateUtilityRate = toggle.ToggledOn;
        }
        else
        {
            throw new MissingReferenceException("Missing Toggle Reference");
        }
        UpdateUtilitiesUI();
    }

    private void UpdateUtilitiesUI()
    {
        if (utilitiesBlock != null)
        {
            Scale(!autoCalculateUtilityRate);
        }
        else
        {
            throw new MissingReferenceException("Missing UIBlock2D Reference");
        }
    }

    private void Scale(bool autoCalculateUtilityRate)
    {
        StartCoroutine(ScaleOverTime(utilitiesBlock, autoCalculateUtilityRate, scaleFadeTime));
    }

    IEnumerator ScaleOverTime(GameObject objectToScale, bool show, float time)
    {
        Vector3 originalScale = objectToScale.transform.localScale;
        Vector3 destinationScale;
        float currentTime = 0.0f;

        if (show)
        {
            destinationScale = new Vector3(1, 1, 1);
        }
        else
        {
            destinationScale = new Vector3(0, 0, 0);
        }

        if (originalScale != destinationScale)
            do
            {
                objectToScale.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
                currentTime += Time.deltaTime;
                yield return null;
            } while (currentTime <= time);

        //Ensure scale is performed correctly from lerp
        objectToScale.transform.localScale = destinationScale;
    }

    public void UpdateResponse(string msg, Color color)
    {
        responseTextblock.color = color;
        responseTextblock.text = msg;
    }

    public void CollectUtilityData()
    {
        UtilityRates utilityRates;

        //error check input fields
        if (!IsZipInputValid())
            return;

        if (!autoCalculateUtilityRate)
        {
            //using manual input
            if (!IsUtilityInputValid()) return;

            utilityRates = new(Single.Parse(electrictyTMP.text), Single.Parse(gasTMP.text), Single.Parse(oilTMP.text), Single.Parse(woodPelletTMP.text));
            if (Int32.TryParse(zipTMP.text, out int zip))
            {
                programManager.climateControlSystemConfig.utilityConfig = new(utilityRates, zip);
                programManager.sceneController.LoadSceneName("ComponentSelectionScene_dakota");
            }
            else
            {
                UpdateResponse("Invalid Zip Code", Color.red);
                Debug.Log($"zipTMP.text: {zipTMP.text}");
            }
        }
        else
        {
            //using auto rates
            if (Int32.TryParse(zipTMP.text, out int zip))
            {
                if (utilityRatesAndZip.zipToState.TryGetValue(zip, out string state))
                {
                    if (utilityRatesAndZip.stateRates.TryGetValue(state, out utilityRates))
                    {
                        programManager.climateControlSystemConfig.utilityConfig = new(utilityRates, zip);
                        programManager.sceneController.LoadSceneName("ComponentSelectionScene_dakota");
                    }
                    else
                    {
                        UpdateResponse("State Rate Data Not Found", Color.red);
                        Debug.Log($"state: {state}");
                    }
                }
                else
                {
                    UpdateResponse("Zip Code Data Not Found", Color.red);
                    Debug.Log($"zip: {zip}");
                }

            }
            else
            {
                UpdateResponse("Invalid Zip Code", Color.red);
                Debug.Log($"zipTMP.text: {zipTMP.text}");
            }
        }
    }

    private bool IsZipInputValid()
    {
        if (string.IsNullOrWhiteSpace(zipTMP.text))
        {
            UpdateResponse("Zip Code is required", Color.red);
            return false;
        }

        try
        {
            if (!Regex.IsMatch(zipTMP.text, @"^\d{5}"))
            {
                UpdateResponse("Zip Code must be a 5 digit number", Color.red);
                return false;
            }
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }

        return true;
    }

    private bool IsUtilityInputValid()
    {
        if ((!Single.TryParse(electrictyTMP.text, out electric)) || Single.Parse(electrictyTMP.text) <= 0)
        {
            UpdateResponse("Electricity must be a positive numerical value", Color.red);
            return false;
        }

        if ((!Single.TryParse(gasTMP.text, out gas)) || Single.Parse(gasTMP.text) <= 0)
        {
            UpdateResponse("Gas must be a positive numerical value", Color.red);
            return false;
        }

        if ((!Single.TryParse(oilTMP.text, out oil)) || Single.Parse(oilTMP.text) <= 0)
        {
            UpdateResponse("Oil must be a positive numerical value", Color.red);
            return false;
        }

        if ((!Single.TryParse(woodPelletTMP.text, out wood)) || Single.Parse(woodPelletTMP.text) <= 0)
        {
            UpdateResponse("Wood Pellet must be a positive numerical value", Color.red);
            return false;
        }

        return true;
    }
}
