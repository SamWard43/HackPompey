using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour {

	public float speed;
    public Rigidbody rb;
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {

        
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");


        Vector3 movement = new Vector3(_horizontal, _vertical, 0f);

        rb.transform.Rotate(movement * speed * Time.deltaTime);
		Debug.Log(rb.gameObject);
    }
}
