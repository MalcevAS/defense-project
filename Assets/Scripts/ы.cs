using UnityEngine;
using UnityEngine.Rendering;

public class e : MonoBehaviour
{
    public float speed = 10f;
    public float mouseSeTsivity = 1f;
    bool looking = false;
    public float speedmove = 1f;
    bool isfastrunning = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * (isfastrunning ? speedmove:speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.E)) 
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartLooking();
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            StopLooking();
        }
        if (looking)
        {
            float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSeTsivity;

            float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * mouseSeTsivity;

            transform.localEulerAngles = new Vector3(newRotationY, newRotationX, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 30f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 10f;
        }
       
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
