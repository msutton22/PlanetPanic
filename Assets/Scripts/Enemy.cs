using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	public int speed; //speed of enemies moving
	public int xMoveDirection; //direction that enemies will go
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (xMoveDirection > 0) { //checking if direction is bigger than 0
			xMoveDirection = -1; //if so, will turn the opposite directions
		} else {
			xMoveDirection = 1; //else moving forward
		}
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMoveDirection, 0) * speed; //game object velocity moving

	}

	void OnCollisionEnter2D(Collision2D collision) //when enemy collides with a bullet
	{
		if (collision.gameObject.tag.Equals ("bullet")) { //if the enemy collides with a bullet
			Destroy (collision.gameObject); //get rid of that bullet
			Destroy(gameObject); //destroy enemy
		}
	}

}
	