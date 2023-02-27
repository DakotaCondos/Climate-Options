using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateInfo : MonoBehaviour
{
    private readonly int _zip;
    private readonly List<float> _averageMonthlyTemp;

    public int Zip { get => _zip; }
    public List<float> AverageMonthlyTemp { get => _averageMonthlyTemp; }

    public ClimateInfo(int zip, List<float> averageMonthlyTemp)
    {
        _zip = zip;
        _averageMonthlyTemp = averageMonthlyTemp;
    }
}
