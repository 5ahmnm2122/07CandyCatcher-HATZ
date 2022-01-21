using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public InputField playerName;

    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Player Name is: " + playerName.text);
        Name.playerNameString = playerName.text;
    }

    public void Restart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
