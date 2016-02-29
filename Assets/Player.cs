using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float maxSpeed = 10f;

	Rigidbody2D _rb;

	void Start(){
		_rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");

		_rb.velocity = new Vector2(move * maxSpeed, _rb.velocity.y);
	}


}
