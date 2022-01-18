using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;
    public float maxPos;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow is held down");
            // Move();
        }
    }

    /* private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");


    }
    */
}
