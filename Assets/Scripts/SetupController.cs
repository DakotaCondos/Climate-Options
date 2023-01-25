using Nova;
using NovaSamples.UIControls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupController : MonoBehaviour
{
    public bool autoCalculateUtilityRate;
    [SerializeField]
    private GameObject novaToggle;
    Toggle toggle;
    [SerializeField]
    GameObject utilitiesBlock;
    [SerializeField]
    private float scaleFadeTime = 0.2f;
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
}
