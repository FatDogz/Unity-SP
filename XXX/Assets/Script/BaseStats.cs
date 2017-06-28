using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class BaseStats{
    public List<StatBonus> BaseAdd { get; set; }

    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public int FinalValue { get; set; }

    public BaseStats(int baseValue, string statName, string statDescription)
    {
        this.BaseAdd = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = StatName;
        this.StatDescription = statDescription;


    }

    public void AddStatBonus(StatBonus statBonus)
{
    this.BaseAdd.Add(statBonus);
}
    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdd.Remove(BaseAdd.Find(x=>x.BonusVaule==statBonus.BonusVaule));

    }
    public int GetCalStatValue()
    {
        this.FinalValue = 0;
        this.BaseAdd.ForEach(x => this.FinalValue += x.BonusVaule);
        FinalValue += BaseValue;
        return FinalValue;
    }


}
