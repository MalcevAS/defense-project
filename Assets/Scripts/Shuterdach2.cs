using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuterdach2 : MonoBehaviour
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
                    dachhealz2 victumState = hit.collider.gameObject.GetComponent<dachhealz2>();
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
