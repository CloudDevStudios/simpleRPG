using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public List<BaseStat> stats = new List<BaseStat>();

    void Start()
    {
        stats.Add(new BaseStat(4, "Power", "Your Power Level"));
        stats[0].AddStatBonus(new StatBonus(5));
        Debug.Log(stats[0].GetCalculatedStartValue());
    }
}
