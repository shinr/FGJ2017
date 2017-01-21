using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightChange : MonoBehaviour {

    private bool isDay;
    Animator anim;

	// Use this for initialization
	void Start () {
        isDay = true;
        anim = GetComponent<Animator>();
        InvokeRepeating("changeDay", 0.0f, 4.0f);
	}

    void changeDay()
    {
        if (isDay)
        {
            anim.SetBool("isDay", false);
            isDay = false;
        } 
        else
        {
            anim.SetBool("isDay", true);
            isDay = true;
        }  
    }
	
	// Update is called once per frame
	void Update () {


    }
}
