using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayerContrl : MonoBehaviour {

    public GameObject playerhand;
    public GameObject EquippedWeapon { get; set; }

    CharacterStat characterStats;
    Weapon equippedWeapon;



    void Start()
    {
        characterStats = GetComponent<CharacterStat>();
    }

    public void EquipWeapon(Item itemToEquip)
    {
        if(EquippedWeapon !=null)
        {
            characterStats.RemoveStatBonus(EquippedWeapon.GetComponent<Weapon>().Stats);
            Destroy(playerhand.transform.GetChild(0).gameObject);
            
        }
        


        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapon/" + itemToEquip.ObjectSlug),
        playerhand.transform.position, playerhand.transform.rotation);

        equippedWeapon = EquippedWeapon.GetComponent<Weapon>();


        equippedWeapon.Stats = itemToEquip.Stats;
        EquippedWeapon.transform.SetParent(playerhand.transform);
        characterStats.AddStatBonus(itemToEquip.Stats);
        Debug.Log(equippedWeapon.Stats[0].GetCalStatValue());

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PerformWeaponAtt();
        }
      
    }

    public void PerformWeaponAtt()
    {
        equippedWeapon.PerformAttack();
    }
}
