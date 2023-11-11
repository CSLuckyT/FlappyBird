using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.0f;
    private float timer = 0.0f;
    public float spawnHeightOffset = 7.0f;
    public LogicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicManager").GetComponent<LogicManagerScript>();
        SpawnPipe();        
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isGameOver == true)
        {
            return;
        }
        else if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0.0f;
        }
        
    }
    void SpawnPipe()
    {
        // Log spawnHeightOffset for debugging
        //Debug.Log("spawnHeightOffset: " + spawnHeightOffset);

        float lowestPoint = transform.position.y - spawnHeightOffset;
        float highestPoint = transform.position.y + spawnHeightOffset;
        
        // Log the lowest and highest points for debugging
        //Debug.Log("Lowest point: " + lowestPoint);
        //Debug.Log("Highest point: " + highestPoint);

        //float randomHeight = Random.Range(lowestPoint, highestPoint);
        //write a randomHeight variable that is a random number between lowestPoint and highestPoint
        //and next randomheight should not differ more than 5 from the previous randomheight
        float randomHeight = Random.Range(lowestPoint, highestPoint);

        // Log the random height for debugging
        //Debug.Log("Random height: " + randomHeight);

        Instantiate(pipe, new Vector3(transform.position.x+40, randomHeight, 0), transform.rotation);
    }
}
