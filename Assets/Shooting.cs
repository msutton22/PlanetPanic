using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public float fireRate = 0;
	public float damage = 10;
   // public LayerMask notToHit;
	float timeToShoot = 0;
	Transform firePoint;
	// Use this for initialization
	void Start () {
		firePoint = transform.FindChild ("Fire Point");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
