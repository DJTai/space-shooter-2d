using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour {

	public static int tempHighScore = 0;
	public static string tempInitials = "XXX";
	public static int highScore1 = 0;
	public static int highScore2 = 0;
	public static int highScore3 = 0;
	public static string initials1 = "XXX";
	public static string initials2 = "XXX";
	public static string initials3 = "XXX";
	Text text;
	public InputField initialsEntered;


	public void printText(){
		text.text = initials1 + ":   " + highScore1 + "\r\n" +
			initials2 + ":   " + highScore2 + "\r\n" +
			initials3 + ":   " + highScore3 + "\r\n";
	}

	public void setText(){
		tempInitials = initialsEntered.ToString ();
		if (tempHighScore >= highScore1) {
			highScore3 = highScore2;
			initials3 = initials2;
			highScore2 = highScore1;
			initials2 = initials1;
			highScore1 = tempHighScore;
			initials1 = tempInitials;
			printText ();
		} else if (tempHighScore >= highScore2) {
			highScore3 = highScore2;
			initials3 = initials2;
			highScore2 = tempHighScore;
			initials2 = tempInitials;
			printText ();
		} else if (tempHighScore >= highScore3) {
			highScore3 = tempHighScore;
			initials3 = tempInitials;
			printText ();
		} else {
			printText ();
		}

		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
}
