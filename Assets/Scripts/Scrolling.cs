using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	private Rigidbody2D RIGIDBODY;
	private float m_Speed = -1.5f;
	[SerializeField]  private bool m_stopScrolling;
	void Start() {
		RIGIDBODY = GetComponent<Rigidbody2D> ();
		RIGIDBODY.velocity = new Vector2 (0, m_Speed);  
	}

	void Update() {
		if (m_stopScrolling)
			RIGIDBODY.velocity = Vector2.zero;
		else
			RIGIDBODY.velocity = new Vector2 (0, m_Speed);

}
}