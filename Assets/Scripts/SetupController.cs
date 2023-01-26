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
    private float woodPellet = 0;


    private void Awake()
    {
        toggle = novaToggle.GetComponent<Toggle>();
        UpdateToggle();
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
        //error check input fields
        if (!IsZipInputValid())
            return;
        if (!autoCalculateUtilityRate && !IsUtilityInputValid())
            return;

        // Call 
        UpdateResponse("Input is valid", Color.green);
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
        if (!Single.TryParse(electrictyTMP.text, out electric))
        {
            UpdateResponse("Electricity must be a numerical value", Color.red);
            return false;
        }

        if (!Single.TryParse(gasTMP.text, out gas))
        {
            UpdateResponse("Gas must be a numerical value", Color.red);
            return false;
        }

        if (!Single.TryParse(oilTMP.text, out oil))
        {
            UpdateResponse("Oil must be a numerical value", Color.red);
            return false;
        }

        if (!Single.TryParse(woodPelletTMP.text, out woodPellet))
        {
            UpdateResponse("Wood Pellet must be a numerical value", Color.red);
            return false;
        }

        return true;
    }
}
