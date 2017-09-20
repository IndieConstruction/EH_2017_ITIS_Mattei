using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


	public Transform PlayerTransform;
	Vector3 v;

	void Start(){
		v = transform.position - PlayerTransform.position;
	}
	void LateUpdate(){
		if (PlayerTransform != null) {
			transform.position = PlayerTransform.position + v;			
		}
	}
}
