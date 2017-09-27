using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour {

	public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.P)) {
			Shoot ();
		}
	}

	public void Shoot(){
		GameObject newBullet = Instantiate (BulletPrefab);
		newBullet.transform.position = transform.position;
		bool direction = GetComponent<Player> ().IsRight;
		newBullet.GetComponent<BulletComponent> ().SetDirection (direction);
	}
}
