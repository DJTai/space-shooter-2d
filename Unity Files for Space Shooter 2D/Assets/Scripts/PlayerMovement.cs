using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 5.0f;

	float shipBoundaryRadius = 0.5f;  // Value representing boundary of player's ship
	float screenRatio;                // Ratio of the screen's width-to-height
	float widthOrtho;                 // Camera's orthographic size * screen ratio

	Vector3 pos;       // Player's position
	Vector3 velocity;  // Player's velocity, both horizontal and vertical

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		screenRatio = (float)Screen.width / (float)Screen.height;  // WARNING! Might be weird/glitchy b.c. of Integers
		widthOrtho = Camera.main.orthographicSize * screenRatio;

		velocity = new Vector3 (Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += velocity;

		/* Restrict the user to the camera's boundaries */
		// Vertical restrictions
		if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}
		// Horizontal restrictions
		if (pos.x + shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if (pos.x - shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}
	
		// Set the player's position
		transform.position = pos;
	}
}
