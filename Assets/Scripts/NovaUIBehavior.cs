using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Nova;

public class NovaUIBehavior : ScriptableObject
{
    public void DisableNovaInteractableClickBehavior(GameObject gameObject)
    {
        Interactable interactable = gameObject.GetComponent<Interactable>();

        if (interactable != null)
        {
            interactable.ClickBehavior = ClickBehavior.None;
        }
    }
}
