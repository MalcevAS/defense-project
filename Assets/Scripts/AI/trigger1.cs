using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "npc")
        {
            other.gameObject.GetComponent<BotMoveController>().nextPoint();
        }
    }
}

