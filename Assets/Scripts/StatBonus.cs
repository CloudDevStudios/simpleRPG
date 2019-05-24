using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBonus
{
    public int BonusValue { get; set; }

    public StatBonus(int BonusValue)
    {
        this.BonusValue = BonusValue;
        Debug.Log("New stat bonus initiated");
    }

}
