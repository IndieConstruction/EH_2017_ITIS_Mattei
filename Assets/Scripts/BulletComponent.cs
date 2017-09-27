using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour {

	public float Speed = 0.01f;
	bool IsRight = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(IsRight == true)
			transform.position += new Vector3 (Speed, 0, 0);
		else
			transform.position -= new Vector3 (Speed, 0, 0);
	}

	public void SetDirection(bool isRight){
		IsRight = isRight;
	}
		
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag =="Malus" || coll.gameObject.tag == "Enemy" ||coll.gameObject.tag == "Boss") {
			Destroy (this.gameObject);
		}
	}}
