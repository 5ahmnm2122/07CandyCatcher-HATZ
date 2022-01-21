using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    public GameObject candyGood;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCandy", 2, 3);
        
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-420, 420);
        return new Vector2(x, 375);
    }

    void SpawnCandy()
    {
        Instantiate(candyGood, GetSpawnPoint(), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
