using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //public float mouseSensitivityX = 1;
    //public float mouseSensitivityY = 1;
    public float speed;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //float moveLR = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        //float moveUD = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        //Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //transform.position = new Vector3(mouse.x,0f, transform.position.y);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(Movement * speed);
    }
}


