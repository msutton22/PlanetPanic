using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TryAgainButton : MonoBehaviour {
	public Text scoreText; //text variable
	public float score = 0; //score holder
	 
	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + (PlayerPrefs.GetFloat ("Score")).ToString(); //changing text of the score text
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {  //if the space bar is pressed, go to next scene
			SceneManager.LoadScene (1);
		}

	
	}

	public void PlayGame() {
		SceneManager.LoadScene (1); //if the button is pressed, go to the game
	}

}
