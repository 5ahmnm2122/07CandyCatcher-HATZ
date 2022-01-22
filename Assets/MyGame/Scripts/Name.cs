using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string playerNameString;
    public static string playerScoreString;

    public Text playerNameText;
    public Text playerScoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = playerNameString;
        playerScoreText.text = playerScoreString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
