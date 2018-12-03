using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

	public int health = 2;
	public float invulnPeriod = 1f;

	float invulnTimer = 0f;
	 //float invulnAnimTimer = 1f;  // TODO:
	int correctLayer;

	SpriteRenderer spriteRend;  // GameObject's SpriteRenderer, i.e., the graphics

	void Start() {
		correctLayer = gameObject.layer;  // Ensure the object is created on the correct layer

		// Only gets rendered on parent object
		spriteRend = GetComponent<SpriteRenderer> ();

		if (spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer> ();

			if (spriteRend == null) {
				Debug.LogError ("Object " + gameObject.name + " has no sprite rendered");
			}
		}
	}

	void OnTriggerEnter2D() {
		// Player was hit
		health--;

		if (invulnPeriod > 0) {
			invulnTimer = invulnPeriod;  // Set timer
			gameObject.layer = 10;       // Send user to invulnerable layer
		}
	}

	void Update() {

		if (invulnTimer > 0) {
			invulnTimer -= Time.deltaTime;

			if (invulnTimer <= 0) {
				// Display player's sprite renderer
				gameObject.layer = correctLayer;
				if (spriteRend != null) {
					spriteRend.enabled = true;
				}

			} else {
				// TODO: Update w/ a better method OR an actual animation
				if (spriteRend != null) {
					spriteRend.enabled = !spriteRend.enabled;
				}
			}
		}

		if (health <= 0) {
			Die ();
		}
	}

	void Die() {
		Destroy (gameObject);
	}
}
