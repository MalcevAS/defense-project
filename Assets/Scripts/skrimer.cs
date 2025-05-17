using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skrimer : MonoBehaviour
{
    public float speed = 15;
    CharacterController controler;

    // Update is called once per frame
    void Update()
    {
        if (TH.i)                                                                                                                                                         
        {
           transform.position-=(transform.right * Time.deltaTime * speed);
        }
    }
}
