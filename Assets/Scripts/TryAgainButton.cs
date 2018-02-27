using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TryAgainButton : MonoBehaviour {
	public Text scoreText;
	public float score = 0; //score holder
	 
	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + (PlayerPrefs.GetFloat ("Score")).ToString();
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
