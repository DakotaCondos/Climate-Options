using System;

[Serializable]
public class UtilityConfig
{
    public UtilityRates utilityrates;
    public int zip;

    public UtilityConfig()
    {
        utilityrates = new UtilityRates();
        zip = 99004;
    }

    public UtilityConfig(UtilityRates utilityrates, int zip)
    {
        this.utilityrates = utilityrates;
        this.zip = zip;
    }



}