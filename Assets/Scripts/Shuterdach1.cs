using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Shuterdach1 : MonoBehaviour
{
    public GameObject externalShootlight;
    private Light shootLight;
    public int enemy = 18;
    IEnumerator stopShoot()
    {
        yield return new WaitForSeconds(1f);
        shootLight.enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(stopShoot());
            Light shootlight = externalShootlight.GetComponent<Light>();
            if (shootlight != null)
            {
                shootlight.enabled = true;
            }
            
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "npc")
                {
                    dachhealz1 victumState = hit.collider.gameObject.GetComponent<dachhealz1>();
                    victumState.makeDamage();
                    enemy = enemy - 1;
                    if (enemy == 0)
                    {
                        Debug.Log("kill");
                    }
                }
            }
        }
    }
    
}

