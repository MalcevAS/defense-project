using UnityEngine;
using UnityEngine.Rendering;

public class alabayplane : MonoBehaviour
{
    public float speed = 10f;
    public float mouseSeTsivity = 1f;
    bool looking = false;
    public float speedmove = 1f;
    bool isfastrunning = false;
    void Start()
    {
       StartLooking();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.W))
        {
            speed = speed + 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = speed - 0.1f;
        }
        if (speed < 0.5f)
        {
            speed = 1f;
        }
        
        /* 
        if (Input.GetKey(KeyCode.W))
         {
             transform.position += transform.forward * Time.deltaTime * speed;
         }
        */
        if (Input.GetKey(KeyCode.A))
         {
              transform.localEulerAngles -= transform.up * Time.deltaTime * speed;
         }
        /*
         if (Input.GetKey(KeyCode.S))
         {
             transform.position -= transform.forward * Time.deltaTime * speed;
         }
        */
        if (Input.GetKey(KeyCode.D))
         {
             transform.localEulerAngles += transform.up * Time.deltaTime * speed;
         }
      
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localEulerAngles += new Vector3(0f, 0f, transform.localEulerAngles.z - 2);
        }
        if (Input.GetKey(KeyCode.E)) 
        {
            transform.localEulerAngles += transform.right * Time.deltaTime * speed;

        }
 
            float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSeTsivity;

            float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * mouseSeTsivity;

            transform.localEulerAngles = new Vector3(0f, newRotationX, 0f);
           //transform.localEulerAngles = new Vector3(newRotationY, 0f, 0f);
           
      
    }

    void StartLooking()
    {
        looking = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void StopLooking()
    {
        looking = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }


}
