using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int ScoreCounter;
	public HudManager hd;

	Player player;

	void Start(){
		player = FindObjectOfType<Player> ();
		hd = FindObjectOfType<HudManager> ();
	}

	void Update(){
		if (player.ActualLife <= 0) {
			SceneManager.LoadScene (0);
		}
	}

	public void Win(){
		// Scrivo che è terminato il livello
		hd.SetWin ();
		// Fermo il gameplay
		Time.timeScale = 0.0001f;
		// ... 
	}

}
