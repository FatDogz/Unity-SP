using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Weapon {

    List<BaseStats> Stats { get; set; }
    void PerformAttack();
}
