
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dachhealz : MonoBehaviour
{
    public float healsz = 100;
 
    public void makeDamage()
    {
        healsz -= 100;
        Debug.Log($"ÃÓ∏ ’œ {healsz}");
        if(healsz <= 0)
        {
            Destroy(gameObject);
        }
    }
}
