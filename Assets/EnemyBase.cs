using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyBase : MonoBehaviour
{
    public virtual void AttackPlayer()
    {
        DebugText("Enemy is attacking player");
        print("Enemy is attacking Player");
    }

    protected void DebugText(string text)
    {
        GameObject TextBox = GameObject.Find("TextBox");
        if (TextBox != null)
        {
            TextBox.GetComponent<TextMeshProUGUI>().SetText(text);
        }
    }

    public virtual void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.white;
        DebugText("");
    }
}
