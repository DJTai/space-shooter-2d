using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	public GameObject bullePrefab;
	Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	int bulletLayer;
	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	AudioSource playerShootSound;

	void Start() {
		bulletLayer = gameObject.layer;
		playerShootSound = this.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		cooldownTimer -= Time.deltaTime;

		if (Input.GetButton ("Fire1") && cooldownTimer <= 0) {
			// Shoot!
			cooldownTimer = fireDelay;
			playerShootSound.Play ();

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate (bullePrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = gameObject.layer;
		}
			
	}
}
