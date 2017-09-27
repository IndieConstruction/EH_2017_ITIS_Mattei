using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {


	public int Life;
	public int Damage;
	public bool IsAlive = true;
	GameManager gm;
	// Use this for initialization
	void Start () {
		gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		CheckLife ();
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Bullet") {
			Life--;
			Debug.Log (Life);
		}
		if (coll.gameObject.tag == "Player") {
			Player p;
			Attack (p = FindObjectOfType<Player> ());
		}
	}
		
	void CheckLife(){
		if (Life <= 0) {
			gm.Win ();
		}
	}

	public void Attack(Player p){
		p = FindObjectOfType<Player> ();
		p.ActualLife -= Damage;
	}
}
