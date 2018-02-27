using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) { 
			SceneManager.LoadScene (1);
		}
	}

	public void PlayGame() {
		SceneManager.LoadScene (1); //if the button is pressed, go to the game
	}

}
