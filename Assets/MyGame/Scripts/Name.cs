using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string playerNameString;

    public Text playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = playerNameString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
