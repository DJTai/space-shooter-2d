using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public GameObject bullePrefab;
	Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	int bulletLayer;

	public float fireDelay = 0.75f;
	float cooldownTimer = 0;

	Transform player;

	void Start() {
		bulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		if (player == null) {
			// Find the player's ship
			GameObject go = GameObject.FindWithTag("Player");

			if (go != null) {
				player = go.transform;
			}
		}

		cooldownTimer -= Time.deltaTime;

		if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 8) {
			// Shoot!
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate (bullePrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = gameObject.layer;
		}

	}
}
