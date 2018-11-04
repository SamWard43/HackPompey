using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
    public Rigidbody spawns;
	public float speed;
    private Rigidbody rb;
    private Vector3 spawnPoint;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = rb.position;
    }
    void FixedUpdate(){   
    
            float _horizontal = Input.GetAxisRaw("Horizontal");
            float _vertical = Input.GetAxisRaw("Vertical");


            Vector3 movement = new Vector3(-_horizontal, 0f, -_vertical);

            rb.AddForce(movement * speed * Time.deltaTime);
            //rb.transform.Translate(movement * speed * Time.deltaTime);

            if(rb.position.y <= -4){
                Destroy(gameObject);
                Instantiate(rb, spawnPoint, Quaternion.identity);
            }
        
    }

     /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("yes");
    }
}
