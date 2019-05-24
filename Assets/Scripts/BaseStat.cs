using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat
{
    public List<StatBonus> BaseAdditives { get; set; }

    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public int BaseValue { get; set; }
    public int FinalValue { get; set; }

    public BaseStat(int BaseValue, string StatName, string StatDescription)
    {
        BaseAdditives = new List<StatBonus>();
        this.BaseValue = BaseValue;
        this.StatName = StatName;
        this.StatDescription = StatDescription;
    }

    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(statBonus);
    }

    public int GetCalculatedStartValue()
    {
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
        FinalValue += BaseValue;
        return FinalValue;
    }





}
