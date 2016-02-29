using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	SpriteRenderer _sprite;

	void Start(){
		_sprite = GetComponent<SpriteRenderer> ();
	}

	void OnMouseDown(){
		_sprite.color = Color.cyan;
	}
}
