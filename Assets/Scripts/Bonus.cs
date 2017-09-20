using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour {


	public int LifeToGive;
	public Player player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			GiveLIfe (player);
			Destroy (this.gameObject);
		}
		Debug.Log (player.ActualLife);
	}

	public void GiveLIfe(Player p){
		if (p.ActualLife<p.Maxlife ) {
			p.ActualLife += LifeToGive;
			if (p.Maxlife >3) {
				p.ActualLife = 3;
			}
		}
	}
}
