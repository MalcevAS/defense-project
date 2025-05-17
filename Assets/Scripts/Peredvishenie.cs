
using UnityEngine;

public class Peredvishenie : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           
            transform.position += Vector3.forward*Time.deltaTime*speed;  
            
        }
        if (Input.GetKey(KeyCode.S))
        {
           
            transform.position +=Vector3.back * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.position +=Vector3.right * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.A))
        {
            
            transform.position +=Vector3.left * Time.deltaTime * speed;

        }

        if (Input.GetMouseButton(0));//0-лкм 1-пкм 2-колесико мыши
        {
            Debug.Log("mouse button pressed");
        }
        
    }
}
