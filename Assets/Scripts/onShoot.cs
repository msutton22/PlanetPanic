using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onShoot : MonoBehaviour {
	public AudioSource Shoot; //shooting audio source
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) { //if the space bar is pressed, play the shooting sound
			Shoot.Play();
		}
	}
}
