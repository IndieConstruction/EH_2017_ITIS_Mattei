using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour {

	public int BonusValue = 100;
	public GameManager gm;

	// Use this for initialization
	void Start () {
		gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player"){
			//Aumenta il punteggio
			gm.ScoreCounter += BonusValue;
			Debug.Log ("Il punteggio è :" + gm.ScoreCounter);
			//Distrugge la Moneta
			Destroy (this.gameObject);
		}
	}
		
}