using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dachhealz1 : MonoBehaviour
{
    public float healsz1 = 100;
    
    public void makeDamage()
    {
        healsz1 -= 50;
        Debug.Log($"ÃÓ∏ ’œ {healsz1}");
        if(healsz1 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
