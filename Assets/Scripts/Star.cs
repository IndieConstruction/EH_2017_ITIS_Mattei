using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		Player p;
		p = FindObjectOfType<Player> ();
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.GetComponent<Player> ().PowerUp ();
			p.IsNormal = false;
			GameObject.Destroy (this.gameObject);
			Debug.Log (p.IsNormal);
		}
	}

}
