using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, Weapon

{
    private Animator animator;

    public List<BaseStats> Stats { get; set; }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void PerformAttack()
    {
        animator.SetTrigger("Base_Attack");
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Enemy")
        {
            col.GetComponent<Enemy>().TakeDamage(Stats[0].GetCalStatValue());
        }
    }
    /*  public void PerformAttack()
      {
          animator.SetTrigger("Base_Attack");
     ( }*/
}
