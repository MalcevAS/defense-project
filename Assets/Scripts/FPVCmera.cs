using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPVCamera : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float mouseSetsiivity = 1f;
    public float fastMovingSpeed = 1.0f;

    bool looking = false;
    bool isFastRunning = false;
    // Update is called once per frame
    void StartLooking()
    {
        looking = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void StopLooking()
    {
        looking = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(isFastRunning);
            transform.position += transform.forward * Time.deltaTime * (isFastRunning ? fastMovingSpeed : moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * (isFastRunning ? fastMovingSpeed : moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * (isFastRunning ? fastMovingSpeed : moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * (isFastRunning ? fastMovingSpeed : moveSpeed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartLooking();
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            StopLooking();
        } 
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isFastRunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isFastRunning = false;
        }
        if (looking)
        {
            float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSetsiivity;
            float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * mouseSetsiivity;
            transform.localEulerAngles = new Vector3(newRotationY, newRotationX, 0f);
        }


    }
    
}