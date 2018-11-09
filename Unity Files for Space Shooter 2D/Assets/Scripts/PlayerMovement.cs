using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 5.0f;
	public float rotSpeed = 180f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// All we need for OUR game
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, 0, 0);
		pos += velocity;
		transform.position = pos;
	}
}
