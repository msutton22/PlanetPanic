﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceShipBehavior : MonoBehaviour {
	public AudioSource Shoot; //audio source variable
	public AudioSource Killed; // audio source variable
	public float speed; //variable for speed of the spaceship
	public float score = 0; //score holder
	public GameObject scoreInGame; //adding game object for score text
	public GameObject projectilePrefabs; //Adding Prefab of projectiles
	private List <GameObject> Projectiles = new List<GameObject> ();  //creating a list of projectile objects
	private float projectileVelocity; //variable for velocity of the projectiles
	// Use this for initialization
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource> (); //making an array of audio sources 
		Killed = audios [0]; //assigning audio sources in array
		Shoot = audios [1];
		projectileVelocity = 6; //stating projectile velocity
		DontDestroyOnLoad (gameObject); 

	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime; //score will increase each second 
		scoreInGame.gameObject.GetComponent<Text>().text = ("Score: " + (int)score); //checking score every frame and printing in textbox what it is
		if (Input.GetKeyDown (KeyCode.Space))  //if the spacebar is pressed 
		{
			GameObject bullet = (GameObject)Instantiate (projectilePrefabs, transform.position, Quaternion.identity); //create a projectile object in the current position
			Projectiles.Add (bullet); //add actual projectial or bullet to scene
			Shoot.Play(); //play shooting sound
		}

		for (int i = 0; i < Projectiles.Count; i++) { //loop to see how many projectiles are in the scene
			GameObject goBullet = Projectiles [i]; //going through list of projectiles to see number of projectiles
			if (goBullet != null) { //checking if goBullet is null
				goBullet.transform.Translate (new Vector3 (0, 1) * Time.deltaTime * projectileVelocity); //Projectiles moving at given velocity over time
				Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint (goBullet.transform.position); // Finding the position of the bullet
				if (bulletScreenPos.y >= Screen.height) { //checking to see if the bullet has gone out of the screen
					DestroyObject (goBullet); //will get rid of bullet if bullet leaves screen
					Projectiles.Remove (goBullet); //Projectile will be removed 
				}
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) { //if right arrow is pressed
			this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));	//spaceship will move right at a speed dictated elsewhere
		}


		if (Input.GetKey (KeyCode.LeftArrow)) { //if left arrow is pressed
			this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));	//spaceship willl move left at a negative speed dictated elsewhere

		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (0, speed));	//spaceship willl move up at a positive speed dictated elsewhere		
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (0, -speed));	//spaceship willl move down at a negative speed dictated elsewhere		
		}
	}


void OnCollisionEnter2D(Collision2D collision) //when you collide with enemy
	{
		PlayerPrefs.SetFloat ("Score", (int)score);
		if (collision.gameObject.tag.Equals ("badGuy")) { //if the player collides with a enemey
			Killed.Play(); //play the killed audio source
			Destroy (collision.gameObject); //get rid of that enemy
			Destroy (gameObject, Killed.clip.length); //destroy the object after the sound is played
			SceneManager.LoadScene (2); //if the player dies, go to end screen
		}
		if (collision.gameObject.tag.Equals ("bullet2")) { //if the player collides with a bullet
			Killed.Play(); //play the killed audio source
			Destroy (collision.gameObject); //get rid of that bullet
			Destroy (gameObject, Killed.clip.length); //destroy player after the sound is played
			SceneManager.LoadScene (2); //if the player dies, go to end screen
		}
			
	}
		

}