using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    public GameObject candyGood;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCandy", 2, 3);
        
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-7, 7);
        return new Vector2(x, 10);
    }

    void SpawnCandy() // Ein Geldsack wird an zufällig ausgewählten Orten gespawned
    {
        GameObject newCandy = Instantiate(candyGood, GetSpawnPoint(), Quaternion.identity);
        newCandy.transform.parent = canvas.transform;
    }
}
