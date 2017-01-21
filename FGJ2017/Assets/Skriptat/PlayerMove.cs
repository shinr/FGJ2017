using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;
    private bool crouch;
    private Vector3 direction = Vector3.right;
    public GameObject bong;

    bool isGrounded = false;
    Animator anim;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Pelaaja kollasi");
        isGrounded = true;
    }

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        BoxCollider2D col = (BoxCollider2D)GetComponent<Collider2D>();

        //Crouch
        if (Input.GetKey(KeyCode.LeftControl))
        {
            bong.GetComponent<BongScript>().changeBongPosition(-0.5f);
            col.size = new Vector2(1.15f, 1.4f);
            col.offset = new Vector2(0.0f, -0.6f);
            anim.SetBool("crouch", true);
        }
            
            
        else
        {
            bong.GetComponent<BongScript>().changeBongPosition(0.5f);
            col.size = new Vector2(1.15f, 2.8f);
            col.offset = new Vector2(0.0f, 0.0f);
            anim.SetBool("crouch", false);
        }


            

        //Jump
        if(isGrounded) { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 350);
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
