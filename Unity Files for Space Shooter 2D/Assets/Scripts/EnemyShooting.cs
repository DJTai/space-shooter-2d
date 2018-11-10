using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public GameObject bullePrefab;
	Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);

	public float fireDelay = 0.75f;
	float cooldownTimer = 0;

	// Update is called once per frame
	void Update () {

		cooldownTimer -= Time.deltaTime;

		if (cooldownTimer <= 0) {
			// Shoot!
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate (bullePrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = gameObject.layer;
		}

	}
}
