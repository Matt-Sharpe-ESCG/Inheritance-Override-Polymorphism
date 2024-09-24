using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : EnemyBase
{
    public override void AttackPlayer()
    {
        print("Goblin is Attacking Player");
    }
    void Start()
    {
        AttackPlayer();
    }
}
