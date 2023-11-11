using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 17f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float increasedMoveSpeed = moveSpeed * 1;
        // Move the pipe to the left
        transform.position = transform.position + (Vector3.left * increasedMoveSpeed) * Time.deltaTime ;
    }
}
