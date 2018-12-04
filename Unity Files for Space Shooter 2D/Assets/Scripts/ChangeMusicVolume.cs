using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeMusicVolume : MonoBehaviour {

    public Slider Volume;
    public AudioSource spaceShooterMusic;

	// Update is called once per frame
	void Update () {
        spaceShooterMusic.volume = Volume.value;
	}
}
