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
    bool inScoreScreen = false;

    void GameStart() {
        inGameplay = true;
        inStartScreen = false;
        inScoreScreen = false;
    }

    void RunEnd()
    {
        inGameplay = false;
        inStartScreen = false;
        inScoreScreen = true;
    }

	// Use this for initialization
	void Start () {
        startGame += GameStart;
        ObstacleMovement.onDeath += RunEnd;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inStartScreen || inScoreScreen)
            {
                startGame();
            }
            
        }
       
    }
}
