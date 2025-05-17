using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ligt : MonoBehaviour
{
    CharacterController controler;
    Light light;
    void Start()
    {
        controler = GetComponent<CharacterController>();
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            light.enabled = !light.enabled;
        }

        Debug.Log("юкюаюх юкюаюх я йервсонл йервсонл");
    }
}
