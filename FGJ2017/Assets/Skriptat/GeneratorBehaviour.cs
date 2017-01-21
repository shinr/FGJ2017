using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBehaviour : MonoBehaviour {
    public GameObject obstacle;

    float spawnTimer = 1.0f;

    enum Levels
    {
        Ground, Air
    }
    Levels currentLevel;

	// Use this for initialization
	void Start () {
        currentLevel = Levels.Ground;
        Invoke("SpawnNewObstacle", spawnTimer);
	}

    void SpawnNewObstacle() {
        Instantiate(obstacle, this.transform.position, Quaternion.identity);
        Invoke("SpawnNewObstacle", spawnTimer);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
