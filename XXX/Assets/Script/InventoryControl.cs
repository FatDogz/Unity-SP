using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour {

    public WeaponPlayerContrl playerweaponcontrol;

    
    
    public Item sword;

    void Start()
    {
        playerweaponcontrol = GetComponent<WeaponPlayerContrl>();
        List<BaseStats> swordStats = new List<BaseStats>();
        swordStats.Add(new BaseStats(10, "DMG", "Your damage level"));
        sword = new Item(swordStats, "LSword");

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            playerweaponcontrol.EquipWeapon(sword);

        }
    }

}
