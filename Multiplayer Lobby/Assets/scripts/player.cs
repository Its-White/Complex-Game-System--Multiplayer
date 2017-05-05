using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
 
    public float movSpeed = 10.0f;
    public float rotationSpeed = 100.0f; //sensitivity
    public float jumpSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float translation = Input.GetAxis("Vertical") * movSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float jump = Input.GetAxis("Jump") * jumpSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        transform.Translate(0, jump, 0);
    

	}
}
