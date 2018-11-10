using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Reference to player's ship
	Transform player;

	public float rotationSpeed = 90f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (null == player) {
			// Find the player's ship
			GameObject go = GameObject.Find("playerShip_blue");

			if (null != go) {
				player = go.transform;
			}
		}

		// Found the player or player doesn't exist
		if (null == player) {
			return;  // Try again next frame
		}

		// We have a player: turn and face it
		Vector3 dir = player.position - transform.position;
		dir.Normalize ();  // CECS 229 Stuff

		float zAngle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90;  // Returns a radian (More CECS 229 stuff I think)
		Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);

		transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
	}
}
