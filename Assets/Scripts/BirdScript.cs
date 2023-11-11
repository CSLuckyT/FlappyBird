using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRidgidBody;
    public float flapForce = 12.5f;
    public LogicManagerScript logic;
    public bool birdIsAlive = true;
    public AudioSource jumpSound;
    public AudioSource hitSound;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name ="John";
        logic = GameObject.Find("LogicManager").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //when left mouse is clicked
        if (Input.GetMouseButtonDown(0) && birdIsAlive)
        {
            Jump();
            jumpSound.Play();
        }        
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            //myRidgidBody.velocity = Vector2.up * 10;
        }
        */

        //when bird jump off the screen, game over
        if (transform.position.y > 22.0f || transform.position.y < -22.0f)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }
    void Jump()
    {
        myRidgidBody.velocity = Vector2.up * flapForce;    
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        //Debug.Log("Bird collided with something");
        logic.gameOver();
        birdIsAlive = false;
        hitSound.Play();
    }

}
