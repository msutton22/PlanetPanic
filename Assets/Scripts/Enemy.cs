﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	public int speed; //speed of enemies moving
	public int xMoveDirection; //direction that enemies will go
	private List<GameObject> Projectiles2 = new List<GameObject>();
	private float projectileVelocity;
	public GameObject projectile2Prefab;
	float nextSpawn = 0.0f;  
	public float spawnRate = 1f; 



	// Use this for initialization
	void Start () {
		projectileVelocity = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (xMoveDirection > 0) { //checking if direction is bigger than 0
			xMoveDirection = -1; //if so, will turn the opposite directions
		} else {
			xMoveDirection = 1; //else moving forward
		}
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMoveDirection, 0) * speed; //game object velocity moving

		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate; // The time it takes for a new enemy to spawn
			GameObject bullet = (GameObject)Instantiate (projectile2Prefab, transform.position, Quaternion.identity);
			Projectiles2.Add (bullet);
		}
		for (int i = 0; i < Projectiles2.Count; i++) {
			GameObject goBullet = Projectiles2 [i];
			if (goBullet != null) {
				goBullet.transform.Translate (new Vector3 (0, -1) * Time.deltaTime * projectileVelocity);
				Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint (goBullet.transform.position);
				if (bulletScreenPos.y <= 0) {
					DestroyObject (goBullet);
					Projectiles2.Remove (goBullet);
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision) //when enemy collides with a bullet
	{
		if (collision.gameObject.tag.Equals ("bullet")) { //if the enemy collides with a bullet
			Destroy (collision.gameObject); //get rid of that bullet
			Destroy(gameObject); //destroy enemy
		}
	}

}