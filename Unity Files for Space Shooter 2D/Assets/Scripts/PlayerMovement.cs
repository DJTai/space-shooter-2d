using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 5.0f;
	public float rotSpeed = 180f;

	Vector3 pos;
	Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// All we need for OUR game
		pos = transform.position;

		velocity = new Vector3 (Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += velocity;

		// Set position
		transform.position = pos;
	}
}
