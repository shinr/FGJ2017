using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBehaviour : MonoBehaviour {
    public GameObject groundObstacle;
    public GameObject airObstacle;

    float spawnTimer = 10.0f;

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
        switch (currentLevel)
        {
            case Levels.Ground:
                Instantiate(groundObstacle, this.transform.position, Quaternion.identity);
                break;
            case Levels.Air:
                Instantiate(airObstacle, this.transform.position + (Vector3.up * 1.5f), Quaternion.identity);
                break;
        }
        
        if (Random.value > 0.5f) {
            currentLevel = currentLevel == Levels.Ground ? Levels.Air : Levels.Ground;
        } 
        Invoke("SpawnNewObstacle", spawnTimer);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
