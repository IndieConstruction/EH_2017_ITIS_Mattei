﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string Name;
	public float MovementSpeed = 0.1f;
	public float JumpForce = 0.1f;
	public int ActualLife = 3;
	public int Maxlife = 3;
	public bool IsRight = true;

	public bool IsNormal = true;
	private bool IsGrounded = true;

	// Use this for initialization
	void Start () {
		Debug.Log ("Il player si chiama : " + Name);
	}				
	
	// Update is called once per frame
	void FixedUpdate () {
		CheckLife ();
		Transform thisTransform;
		thisTransform = gameObject.GetComponent<Transform>();

		Animator thisAnimator;
		thisAnimator = gameObject.GetComponent<Animator>();

		if (Input.GetKey (KeyCode.A)) {
			// Vado a sinistra
			thisTransform.position = thisTransform.position + new Vector3 (-MovementSpeed, 0f, 0f);
			thisAnimator.SetInteger ("MovementState", 2);
			IsRight = false;
			// gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (-MovementSpeed, 0), ForceMode2D.Impulse);
		}else if(Input.GetKey(KeyCode.D)){
			// Vado a destra
			thisTransform.position = thisTransform.position + new Vector3 (MovementSpeed, 0f, 0f);
			thisAnimator.SetInteger ("MovementState", 1);
			IsRight = true;
			// gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (MovementSpeed, 0), ForceMode2D.Impulse);
		}else{
			thisAnimator.SetInteger ("MovementState", 0);
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

	void CheckLife(){
		if (ActualLife <= 0) {
			Destroy (this.gameObject);
			Debug.Log (ActualLife);
		}
	}

	/// <summary>
	/// Apllica gli effetti del powerup sul player.
	/// </summary>
	public void PowerUp(){
		gameObject.GetComponent<Transform>().localScale = new Vector3(2f, 2f);
	}
	/// <summary>
	/// Applia gli effetti del powerDown sul player.
	/// </summary>
	public void PowerDown(){
		gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1f);
	}
}