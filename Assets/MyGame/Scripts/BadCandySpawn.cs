using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCandySpawn : MonoBehaviour
{
    public GameObject candyBad;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCandy", 5, 7);
        
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-7, 7);
        return new Vector2(x, 10);
    }

    void SpawnCandy()
    {
        GameObject newBadCandy = Instantiate(candyBad, GetSpawnPoint(), Quaternion.identity);
        newBadCandy.transform.parent = canvas.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
