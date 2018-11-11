using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;  // TODO: Make an array of enemy prefabs

	float spawnDistance = 10f;
	float enemyRate = 5f;
	float nextEnemy = 1f;
	
	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime;

		if (nextEnemy <= 0) {
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;

			if (enemyRate <= 1) {
				enemyRate = 1.5f;
			}

			Vector3 offset = Random.onUnitSphere;
			offset.z = 0;  // Very important for 2D
			offset.y = 5;
			offset = offset.normalized * spawnDistance;

			Instantiate (enemyPrefab, transform.position + offset, Quaternion.identity);
		}
		
	}
}
