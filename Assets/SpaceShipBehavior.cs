﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipBehavior : MonoBehaviour {
	public float speed;
	SpriteRenderer spaceship;

	public GameObject projectilePrefabs;
	private List <GameObject> Projectiles = new List<GameObject> ();
	private float projectileVelocity;
	// Use this for initialization
	void Start () {
		spaceship = this.GetComponent<SpriteRenderer> ();
		projectileVelocity = 5;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) 
		{
			GameObject bullet = (GameObject)Instantiate (projectilePrefabs, transform.position, Quaternion.identity);
			Projectiles.Add (bullet);
		}

		for (int i = 0; i < Projectiles.Count; i++) {
			GameObject goBullet = Projectiles [i];
			if (goBullet != null) {
				goBullet.transform.Translate (new Vector3 (0, 1) * Time.deltaTime * projectileVelocity);
				Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint (goBullet.transform.position);
				if (bulletScreenPos.y >= Screen.height) {
					DestroyObject (goBullet);
					Projectiles.Remove (goBullet);
				}
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));	
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));		
		}
	}
}
