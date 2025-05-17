using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class RayCuzt : MonoBehaviour
{
    GameObject lastHit = null;
    GameObject currentHit = null;
    void Update()
    {
       Ray ray = new Ray(transform.position, transform.forward);
       Debug.DrawRay(ray.origin, ray.direction, Color.cyan);
       RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            lastHit = currentHit;
            if (lastHit != null)
            {
                lastHit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            currentHit = hit.transform.gameObject;
            currentHit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }
       else
        {
            lastHit = currentHit;
            if (lastHit != null)
            {
                lastHit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            currentHit = null;
        }
    }
}
