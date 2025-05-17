using JetBrains.Annotations;
using UnityEngine;

public class TH : MonoBehaviour
{
    public static bool i;
    private void OnTriggerEnter(Collider other)
    {
        i = true;
        
        Debug.Log("юююююююююююююююююююююююююююююю люлю бшйхмскю цнлсмйскю юююююююююююююююююююююююююююююююююююю люлю бшйхмскю цнлсмйскю");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("спююююююююююююююююююююююю люлю бепмскю цнлсмйскю спююююююююююююююююююююююююююююююююююююю люлю бепмскю цнлсмйскю");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("ююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююю цде лни цнлсмйск юююююююююююююююююююююююююююю цде лни цнлсмйск");
    }
}
