using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float sensi = 100f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            float mouseX = Input.GetAxis("Mouse X") * sensi * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensi * Time.deltaTime;
            transform.Rotate(Vector3.forward * mouseX);
            transform.Rotate(Vector3.back * mouseY);
        }
    }
}
