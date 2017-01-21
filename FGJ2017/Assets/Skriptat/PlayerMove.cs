using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;
    private bool crouch;
    private Vector3 direction = Vector3.right;

    Animator anim;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Pelaaja kollasi");
    }

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
		
	}

    void FixedUpdate()
    {

        //Crouch
        if (Input.GetKey(KeyCode.LeftControl))
            anim.SetBool("crouch", true);
        else
            anim.SetBool("crouch", false);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed/2);
        }
            
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
