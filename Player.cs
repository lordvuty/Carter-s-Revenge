using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ElementoGrafico {

    Animator anim;

	Girl myGirl;

    Vector3 pos;
    Vector3 size;
    Vector3 sizeplus;
    bool facingRight = true;
    Rigidbody2D rb;
    public float speed = 2.5f;

    public void init() {

        

        pos = new Vector3(-10, -3, 0);
        size = new Vector3(3, 2.5f, 1);
        sizeplus = new Vector3(4, 3, 1);

        gobj = Instantiate(Resources.Load("player11", typeof(GameObject))) as GameObject;

        gobj.transform.localScale = size;
        gobj.transform.position = pos;

        anim = gobj.GetComponent<Animator>();
        rb = gobj.GetComponent<Rigidbody2D>();

		Debug.Log ("player");

    }
    public void mover() {

        /*if (Input.GetKey(KeyCode.LeftArrow) && gobj.transform.position.x >= -11)
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(speed *-1, 0);
            //pos.x = pos.x + (0.5f * Time.deltaTime);
            anim.SetBool("walking", true);

        }
        if (Input.GetKey(KeyCode.RightArrow) && gobj.transform.position.x <= 11)
        {

            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(speed, 0);
            //pos.x = pos.x + (-0.5f * Time.deltaTime);
            anim.SetBool("walking", true);

        }
        else
        {
            anim.SetBool("walking", false);
        }
      
        */

        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if(move != 0)
        {
            anim.SetBool("walking", true);
        }
        if(move == 0){
            anim.SetBool("walking", false);
        }
        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight) {
            Flip();
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gobj.transform.localScale = sizeplus;
			myGirl.anim.SetBool("sex", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //gobj.transform.localScale = size;
			myGirl.anim.SetBool("sex", false);
        }
        
    }

    // Update is called once per frame
    public void Update () {
        mover();
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = gobj.transform.localScale;
        theScale.x *= -1;
        gobj.transform.localScale = theScale;
    }
}