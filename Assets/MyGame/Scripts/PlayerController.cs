using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));

        /* float inputX = Input.GetAxis("Horizontal");

        Debug.Log(inputX);

        player.transform.position = player.transform.position + Vector3.right * inputX * moveSpeed * Time.deltaTime; */
    }
}