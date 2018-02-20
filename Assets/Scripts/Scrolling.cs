using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	private Rigidbody2D RIGIDBODY; 
	private float Speed = -1.5f; //speed of scrolling
	[SerializeField]  private bool stopScrolling;
	void Start() {
		RIGIDBODY = GetComponent<Rigidbody2D> ();
		RIGIDBODY.velocity = new Vector2 (0, Speed);   //how fast the screen will fall down (scroll)
	}

	void Update() {
		if (stopScrolling)
			RIGIDBODY.velocity = Vector2.zero; //if the background is off the page, stop scrolling
		else
			RIGIDBODY.velocity = new Vector2 (0, Speed); //else scroll background

}
}