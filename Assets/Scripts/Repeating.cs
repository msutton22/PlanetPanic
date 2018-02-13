using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : MonoBehaviour {

	private float m_BackgroundSize;
	// Use this for initialization
	void Start () {

		m_BackgroundSize = 10.2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -m_BackgroundSize)
			RepeatBackground ();
	}

	void RepeatBackground() {
		Vector2 BGoffset = new Vector2 (0, m_BackgroundSize * 2f );
		transform.position = (Vector2)transform.position + BGoffset;
	}
}
