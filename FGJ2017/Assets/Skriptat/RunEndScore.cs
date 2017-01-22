using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunEndScore : MonoBehaviour {
    public static long score;
    public static void SetScore(long score)
    {
        RunEndScore.score = score;
    }

    void Disable()
    {
        this.GetComponent<Text>().enabled = false;
    }

    void Enable()
    {
        this.GetComponent<Text>().enabled = true;
    }

    // Use this for initialization
    void Start()
    {
        GameState.startGame += Disable;
        ObstacleMovement.onDeath += Enable;
    }

    // Update is called once per frame
    void Update () {
        this.GetComponent<Text>().text = RunEndScore.score.ToString();
	}
}
