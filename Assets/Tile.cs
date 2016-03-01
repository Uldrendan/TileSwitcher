using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    SpriteRenderer _sprite;
	BoxCollider2D _collider;

    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
		_collider = GetComponent<BoxCollider2D> ();
    }

    void OnMouseDown()
    {
		_collider.isTrigger = !(_collider.isTrigger); 
        if(_sprite.color == Color.green)
        {
            _sprite.color = Color.red;
        }

        else if(_sprite.color == Color.red)
        {
            _sprite.color = Color.blue;
        }

        else if(_sprite.color == Color.blue)
        {
            _sprite.color = Color.green;
        }
    }
}
