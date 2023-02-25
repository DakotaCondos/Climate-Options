using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsEnabledController : MonoBehaviour
{
    [SerializeField] List<GameObject> objects = new();

    public void SetAllActive(bool value)
    {
        foreach (GameObject item in objects)
        {
            item.SetActive(value);
        }
    }

    public void SetItemActive(GameObject item, bool value)
    {
        if (!objects.Contains(item))
        {
            Debug.LogWarning("GameObject not found in list");
            return;
        }

        item.SetActive(value);
    }
}
