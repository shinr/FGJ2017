using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
  
    public delegate void ResetGame();
    public static event ResetGame resetGame;

    bool isInGameplay;

    void StartGame() {
    
    }

	// Use this for initialization
	void Start () {
        isInGameplay = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
