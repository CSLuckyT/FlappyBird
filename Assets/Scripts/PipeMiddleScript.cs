using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicManager").GetComponent<LogicManagerScript>();
        //Below also works
        //logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        //Debug.Log("First Bird collided with pipe middle");
        
        /*
        if (collision.gameObject.name == "Bird")
        {
            //LogicManagerScript logicManagerScript = GameObject.Find("LogicManager").GetComponent<LogicManagerScript>();
            Debug.Log("Bird collided with pipe middle");
            logic.addScore(1);
        }
        */
        
        //Below also works
        
        if (collision.gameObject.layer==3)
        {            
            logic.addScore(null);
        }
        
    }
}
