using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 2);
	}

	public void QuitGame() {
		Debug.Log ("QUIT");
		Application.Quit ();
	}
	 
	public void returnHome(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}

//	public void setText(){
//		HighScores.tempInitials = HighScores.initialsEntered.ToString ();
//
//		if (HighScores.tempHighScore >= HighScores.highScore1) {
//			HighScores.highScore3 = HighScores.highScore2;
//			HighScores.initials3 = HighScores.initials2;
//			HighScores.highScore2 = HighScores.highScore1;
//			HighScores.initials2 = HighScores.initials1;
//			HighScores.highScore1 = HighScores.tempHighScore;
//			HighScores.initials1 = HighScores.tempInitials;
//		} else if (HighScores.tempHighScore >= HighScores.highScore2) {
//			HighScores.highScore3 = HighScores.highScore2;
//			HighScores.initials3 = HighScores.initials2;
//			HighScores.highScore2 = HighScores.tempHighScore;
//			HighScores.initials2 = HighScores.tempInitials;
//		} else if (HighScores.tempHighScore >= HighScores.highScore3) {
//			HighScores.highScore3 = HighScores.tempHighScore;
//			HighScores.initials3 = HighScores.tempInitials;
//		} else {
//		}
//
//		SceneManager.LoadScene (0, LoadSceneMode.Single);
//	}


}
