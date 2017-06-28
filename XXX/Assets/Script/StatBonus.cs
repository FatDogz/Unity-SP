using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBonus {

    public int BonusVaule { get; set; }

    public StatBonus(int bonusVaule)
    {
        this.BonusVaule = bonusVaule;
        Debug.Log("Newstats");
    }
	
}
