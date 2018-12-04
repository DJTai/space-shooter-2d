using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour {

	public static int tempHighScore = 0;
	public static string tempInitials = "XXX";

	public int highScore1 = 0;
	public static int highScore2 = 0;
	public static int highScore3 = 0;

	public static string initials1 = "XXX";
	public static string initials2 = "XXX";
	public static string initials3 = "XXX";

	public static InputField initialsEntered;


	public void setText() {
//		tempInitials = initialsEntered.ToString ();
//
//		if (tempHighScore >= highScore1) {
//			highScore3 = highScore2;
//			initials3 = initials2;
//			highScore2 = highScore1;
//			initials2 = initials1;
//			highScore1 = tempHighScore;
//			initials1 = tempInitials;
//		} else if (tempHighScore >= highScore2) {
//			highScore3 = highScore2;
//			initials3 = initials2;
//			highScore2 = tempHighScore;
//			initials2 = tempInitials;
//		} else if (tempHighScore >= highScore3) {
//			highScore3 = tempHighScore;
//			initials3 = tempInitials;
//		} else {
//		}

		highScore1 = Score.scoreValue;
		// Set initials
		// set score to highScore1

		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
		
}
