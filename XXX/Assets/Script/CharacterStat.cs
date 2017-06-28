using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour {
    // 1st test
    public List<BaseStats> stats = new List<BaseStats>();

   void Start()
   {
       stats.Add(new BaseStats(5, "HP", "Your heath level"));
       stats.Add(new BaseStats(5, "DMG", "Your damage level"));
       stats.Add(new BaseStats(5, "DEF", "Your armor level"));
       
     
   }
    public void AddStatBonus(List<BaseStats>statBonuses)
   {
        foreach(BaseStats statBonus in statBonuses)
        {
            stats.Find(x=> x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
   }
    public void RemoveStatBonus(List<BaseStats> statBonuses)
    {
        foreach (BaseStats statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonus.StatName).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

}
