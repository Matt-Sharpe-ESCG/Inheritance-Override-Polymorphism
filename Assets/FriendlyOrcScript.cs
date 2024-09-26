using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyOrcScript : OrcScript
{
    public override void AttackPlayer()
    {
        DebugText("Friendly Orc Is Attacking Player");
        print("Friendly Orc is attacking Player");
    }

    public override void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
