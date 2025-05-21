using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dachhealz2 : MonoBehaviour
{
    public float healsz2 = 100;

    public void makeDamage()
    {
        healsz2 -= 25;
        Debug.Log($"ÃÓ∏ ’œ {healsz2}");
        if (healsz2 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
