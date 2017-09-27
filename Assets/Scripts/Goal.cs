using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public GameManager GM;

	void Start(){
		GM = FindObjectOfType<GameManager> ();
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			GM.ChangeScene();
			//GM.Win();
		}
	}

}
