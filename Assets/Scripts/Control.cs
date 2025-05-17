using UnityEngine;

public class Control : MonoBehaviour
{
    CharacterController controler;
    public float gravity = 20f;
    public float speed = 15;
    public float rspeed = 15;
    void Start()
    {
       controler = GetComponent<CharacterController>();
      
    }
 
    void Update()
    {
       if (!controler.isGrounded)
        {
            controler.Move(new Vector3(0, -1 * Time.deltaTime * gravity, 0));
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                controler.Move(transform.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                controler.Move(-transform.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 10f * Time.deltaTime * rspeed));
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0,-10f * Time.deltaTime * rspeed));
            }
            if (Input.GetKey(KeyCode.Space))
            {
                controler.Move(new Vector3(0,1,0)*Time.deltaTime * speed);
            }

        }
       
           
    }
}
