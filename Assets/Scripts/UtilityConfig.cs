using System;

[Serializable]
public class UtilityConfig
{
    public UtilityRates utilityrates;
    public int zip;

    public UtilityConfig(UtilityRates utilityrates, int zip)
    {
        this.utilityrates = utilityrates;
        this.zip = zip;
    }
}