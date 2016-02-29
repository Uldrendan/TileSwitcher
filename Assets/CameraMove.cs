using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public Transform target;
	
	void Update () {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
	}
}
