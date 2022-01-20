using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));

        // Debug.Log("Update works");
        /*if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right Arrow is held down");
        } */
    }
}