using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class Shuterdach : MonoBehaviour
{
    public float enemy = 4;
    public GameObject externalShootlight;
    private Light shootLight;

    IEnumerator stopShoot()
    {
        yield return new WaitForSeconds(1f);
        shootLight.enabled = false;
        Debug.Log("¬¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿¿…  ¿–”“»Õ¿ —¡›∆¿À¿");
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
                    dachhealz victumState = hit.collider.gameObject.GetComponent<dachhealz>();
                    Debug.Log("ddfd");
                    victumState.makeDamage();
                    enemy = enemy - 1;
                    if (enemy == 0)
                    {
                        SceneManager.LoadScene(2);
                    }
                }
                }
            }
        }
    }