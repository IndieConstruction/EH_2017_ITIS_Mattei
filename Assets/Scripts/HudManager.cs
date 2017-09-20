using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour {

	public Text score;
	public Image Heart1;
	public Image Heart2;
	public Image Hearth3;

	public GameManager gm;

	public void Update(){
		SetScore ();
	}

	public void SetScore(){
		score.text = gm.ScoreCounter.ToString();
		//Debug.Log ("Score updated: " + gm.ScoreCounter); 
	}
}
