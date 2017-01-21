using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunStart : MonoBehaviour {
    void Disable()
    {
        this.GetComponent<Image>().enabled = false;
        
    }

    void Enable()
    {
        this.GetComponent<Image>().enabled = true;
        Invoke("Disable", 6.66f);
    }

    // Use this for initialization
    void Start()
    {
        GameState.startGame += Enable;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
