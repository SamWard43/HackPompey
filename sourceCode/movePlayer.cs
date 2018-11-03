using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

	public Rigidbody rb;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float _horizontal = Input.GetAxisRaw("Horizontal");
		float _vertical = Input.GetAxisRaw("Vertical");
		

		Vector3 movement = new Vector3(_horizontal, _vertical, 0f);

		rb.transform.Translate(movement * moveSpeed * Time.deltaTime);

	}
}
