using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colsizion : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("раис я срать хочу");
        collision.transform.SetParent(this.transform);
    }
}
