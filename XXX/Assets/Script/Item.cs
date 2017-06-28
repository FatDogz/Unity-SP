using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item  {
    public List<BaseStats> Stats { get; set; }
    public string ObjectSlug { get; set; }
	
    public Item(List<BaseStats> stats, string objectslug)
    {
        this.Stats = stats;
        this.ObjectSlug = objectslug;
    }
}
