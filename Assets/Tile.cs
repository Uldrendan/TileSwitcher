using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    SpriteRenderer _sprite;

    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
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
