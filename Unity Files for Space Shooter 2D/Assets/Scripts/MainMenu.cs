using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

	public void printScore() {
	}
}
