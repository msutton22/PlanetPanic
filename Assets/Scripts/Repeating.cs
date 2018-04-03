using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : MonoBehaviour {

	private float BackgroundSize; 
	// Use this for initialization
	void Start () {

		BackgroundSize = 28.46f; //size of one of the background images
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -BackgroundSize) //if getting to the end of a background
			RepeatBackground (); // perform function
	}

	void RepeatBackground() {
		Vector2 BGoffset = new Vector2 (0, BackgroundSize * 2f ); //telling how where to reapeat the background
		transform.position = (Vector2)transform.position + BGoffset; //creating repeat of background
	}
}
