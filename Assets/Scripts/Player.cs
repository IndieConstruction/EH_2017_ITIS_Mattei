using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string Name;
	public float MovementSpeed = 0.1f;
	public float JumpForce = 0.1f;

	private bool IsGrounded = true;

	// Use this for initialization
	void Start () {
		Debug.Log ("Il player si chiama : " + Name);
	}				
	
	// Update is called once per frame
	void Update () {
		Transform thisTransform;
		thisTransform = gameObject.GetComponent<Transform>();

		if (Input.GetKey (KeyCode.A)) {
			// Vado a sinistra
			thisTransform.position = thisTransform.position + new Vector3 (-MovementSpeed, 0f, 0f);
		}else if(Input.GetKey(KeyCode.D)){
			// Vado a destra
			thisTransform.position = thisTransform.position + new Vector3 (MovementSpeed, 0f, 0f);
		}

		if (Input.GetKeyDown(KeyCode.O) && IsGrounded == true) {
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0, JumpForce));
		}
	}

	void OnCollisionStay2D(Collision2D coll){
		IsGrounded = true;
	}

	void OnCollisionExit2D(Collision2D coll){
		IsGrounded = false;
	}
}