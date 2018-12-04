using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour {

	int highScore1 = 0;
	int highScore2 = 0;
	int highScore3 = 0;
	string initials1 = "XXX";
	string initials2 = "XXX";
	string initials3 = "XXX";
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		text.text = initials1 + ":   " + highScore1 + "\r\n" +
			initials2 + ":   " + highScore2 +  "\r\n" +
			initials3 + ":   " + highScore3;
		
	}
}
