using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) //when enemy collides with a bullet
	{

		if (collision.gameObject.tag.Equals ("bullet")) { //if the enemy collides with a bullet
			Destroy (collision.gameObject); //get rid of that bullet
			Destroy(gameObject); //destroy enemy
		}
	}

}
	