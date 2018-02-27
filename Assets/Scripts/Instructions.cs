﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) { 
			SceneManager.LoadScene (0);
		}
	}

	public void PlayGame() {
		SceneManager.LoadScene (3); //if the button is pressed, go to the game

	}

}
