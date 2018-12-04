using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameOver = false;
	bool bossDefeated = false;

	public float restartDelay = 5f;
	public float nextLevelDelay = 5f;

	public GameObject completeLevelUI;

	public void GameOver() {
		// Player died before defeating the boss
		Debug.Log ("Game over");
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

	public void BossDefeated() {
		// Boss is defeated -> start next level
		Debug.Log ("Boss defeated");
		Invoke ("CompleteLevel", 2f);
	}

	void CompleteLevel() {
		completeLevelUI.SetActive (true);
		Invoke ("NextLevel", nextLevelDelay);
	}

	void RestartLevel() {
		// Reload scene
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	void NextLevel() {
		// Load the next level as indicated in the build settings
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
