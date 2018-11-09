using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

	public int health = 1;
	float invulnTimer = 0;
	int correctLayer;

	void Start() {
		correctLayer = gameObject.layer;
	}

	void OnTriggerEnter2D() {
		Debug.Log ("Trigger!");

		health--;
		invulnTimer = 0.50f;
		gameObject.layer = 10;
	}

	void Update() {

		invulnTimer -= Time.deltaTime;

		if (invulnTimer <= 0) {
			gameObject.layer = correctLayer;
		}

		if (health <= 0) {
			Die ();
		}
	}

	void Die() {
		Destroy (gameObject);
	}
}
