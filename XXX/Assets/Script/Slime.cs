using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, Enemy {

    public float currentHP, damage, armor;
    public float maxHP;

     void Start()
    {
        currentHP = maxHP;
    }
    public void PerformActtack()
    {
      
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        if(currentHP <=0)
        {
            Destroy(gameObject);
        }

    }


}
