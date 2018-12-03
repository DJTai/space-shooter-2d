using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab;
	GameObject playerInstance;

	public int numLives = 4;

	float respawnTimer;

	// Use this for initialization
	void Start () {
		SpawnPlayer ();
	}

	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1f;
		playerInstance = (GameObject)Instantiate (playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if (respawnTimer <= 0) {
				SpawnPlayer ();
			}
		}
	}

	/**
	 * Displays the number of remaining lives on the GUI
	 **/
	void OnGUI() {
		if (numLives > 0 || playerInstance != null) {
			GUI.Label (new Rect (0, 0, 150, 50), "Remaining Lives: " + numLives);
		} else {
			GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "GAME OVER");

			// Go to Initials Screen
			FindObjectOfType<GameManager> ().GameOver ();
		}
	}
}
