using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float maxSpeed = 10f;
	public float jumpForce = 700f;
	bool grounded = false;

    Rigidbody2D _rb;

	void Start () {
        _rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");

		_rb.velocity = new Vector2 (move * maxSpeed, _rb.velocity.y);
	}

	void Update(){
		if(grounded && Input.GetKeyDown(KeyCode.Space)){
			grounded = false;
			_rb.AddForce(new Vector2(0,jumpForce));
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Tile") {
			grounded = true;
		}
	}
}
