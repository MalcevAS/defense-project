using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class onoff : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        GetComponent<MeshRenderer>().enabled = false;
    }
}
