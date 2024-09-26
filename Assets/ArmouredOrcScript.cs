using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmouredOrcScript : OrcScript
{
    public override void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        DebugText("Armoured Orc Is Attacking");
        print("Armoured Orc is attacking Player");
    }
}
