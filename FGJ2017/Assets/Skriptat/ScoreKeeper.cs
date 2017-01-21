using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    long score;

    Text text;
    
    void ResetScoreKeeper()
    {
        score = 0;
    }

    void IncreaseScore()
    {
        text.text = "Score: "+ score.ToString();
        score += 1;
    }

    // register events
    void OnEnable()
    {
        text = this.GetComponent<Text>();
        ObstacleMovement.onDeath += ResetScoreKeeper;
        GameState.startGame += ResetScoreKeeper;
    }

	// Use this for initialization
	void Start () {
        InvokeRepeating("IncreaseScore", 0.0f, 1.0f);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
