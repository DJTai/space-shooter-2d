using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSelfDestruct : MonoBehaviour {

	Vector3 pos;  // Meteor's position

	float meteorBoundaryRadius = 0.5f;

	float screenRatio;  // Ratio of the screen's width-to-height
	float widthOrtho;   // Camera's orthographic size * screen ratio

	// Update is called once per frame
	void Update () {
		pos = transform.position;
		screenRatio = (float)Screen.width / (float)Screen.height;  // WARNING! Might be weird/glitchy b.c. of Integers
		widthOrtho = Camera.main.orthographicSize * screenRatio;

		// Destory meteor once below Camera's x-axis
		if (pos.y + meteorBoundaryRadius < -Camera.main.orthographicSize) {
			Destroy (gameObject);
		}
	}
}
