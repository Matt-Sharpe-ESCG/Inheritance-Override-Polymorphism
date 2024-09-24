using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfScript : EnemyBase
{
    public override void AttackPlayer()
    {
        print("Werewolf is Attacking Player");
    }
    void Start()
    {
        AttackPlayer();
    }
}
