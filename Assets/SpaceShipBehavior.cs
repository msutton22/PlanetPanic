using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipBehavior : MonoBehaviour {
	public float speed;
	SpriteRenderer spaceship;
	// Use this for initialization
	void Start () {
		spaceship = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));	
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));		
		}
	}
}
