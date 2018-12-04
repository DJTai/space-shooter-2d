using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToDefaultPage : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
}
