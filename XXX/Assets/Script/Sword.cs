using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, Weapon

{


    public List<BaseStats> Stats { get; set; }
    public void PerformAttack()
    {
        Debug.Log("Attack !!!");
    }
}
