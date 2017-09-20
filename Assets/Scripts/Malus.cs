using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malus : MonoBehaviour {


	public int Damage;
	public Player player;


	void OnCollisionEnter2D(Collision2D coll){
		RemoveLife (player);

	}

	public void RemoveLife(Player p){
		if (p.IsNormal == true) {
			p.ActualLife -= Damage;
		} else {
			p.IsNormal = true;
			player.PowerDown ();
		}
	}


}
