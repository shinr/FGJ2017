using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    public delegate void StartGame();
    public static event StartGame startGame;
      
    public delegate void ResetGame();
    public static event ResetGame resetGame;

    bool inGameplay = false;
    bool inStartScreen = true;

    void GameStart() {
        inGameplay = true;
        inStartScreen = false;
    }

	// Use this for initialization
	void Start () {
        startGame += GameStart;

	}
	
	// Update is called once per frame
	void Update () {
        if(inStartScreen) { 
	        if(Input.GetKeyDown(KeyCode.Space))
            {
                startGame();
            }
        }
    }
}
