﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile2Code : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) //when projectial collides with a bullet
	{
		if (collision.gameObject.tag.Equals ("bullet")) { //if the projectile collides with a bullet
			Destroy (collision.gameObject); //get rid of that bullet
			Destroy(gameObject); //destroy projectile		

		}
		if (collision.gameObject.tag.Equals ("ground")) { //if the projectile collides with a ground
			Destroy(gameObject); //destroy projectile		

		}
	}


}