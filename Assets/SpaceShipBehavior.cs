using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipBehavior : MonoBehaviour {
	public float speed; //variable for speed of the spaceship
	SpriteRenderer spaceship; //sprite renderer for spaceship

	public GameObject projectilePrefabs; //Adding Prefab of projectiles
	private List <GameObject> Projectiles = new List<GameObject> ();  //creating a list of projectile objects
	private float projectileVelocity; //variable for velocity of the projectiles
	// Use this for initialization
	void Start () {
		spaceship = this.GetComponent<SpriteRenderer> (); // creating sprite renderer for spaceship
		projectileVelocity = 5; //stating projectile velocity
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump"))  //if the spacebar is pressed 
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
