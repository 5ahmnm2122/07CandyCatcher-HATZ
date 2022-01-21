using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCollision : MonoBehaviour
{
    public float count;
    public GameObject candy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /* void OnCollisionEnter(Collision candy)
    {
        if (candy.gameObject.tag == "Candy")
        {
            // Destroy(gameObject, .5f);
            //count++;
            Debug.Log("Yeah, that was definitely a collison!");
        }
    } */

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Candy")
        {
            Debug.Log("And that's the trigger.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
