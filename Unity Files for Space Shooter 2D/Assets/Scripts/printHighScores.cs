using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printHighScores : MonoBehaviour {

	Text text;

	public HighScores highScores;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		highScores = GetComponent<HighScores> ();
	}
	
	// Update is called once per frame
//	void Update () {
//		text.text = HighScores.initials1 + ":   " + HighScores.highScore1 + "\r\n" +
//			HighScores.initials2 + ":   " + HighScores.highScore2 + "\r\n" +
//			HighScores.initials3 + ":   " + HighScores.highScore3 + "\r\n";
//	}
}
