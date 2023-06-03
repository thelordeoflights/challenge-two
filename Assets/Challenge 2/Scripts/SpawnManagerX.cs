using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    public float spawninterval = 4;


    // Start is called before the first frame update
    void Start()
    {
        spawninterval = Random.Range(3,5);
        InvokeRepeating("SpawnRandomBall", startDelay, spawninterval);
    }

    void SpawnRandomBall ()// Spawn random ball at random x position at top of play area
    {
        int ballindex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);  // Generate random ball index and random spawn position
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);       // instantiate ball at random spawn location
    }

    
}
