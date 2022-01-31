using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public InputField playerName;

    // Start is called before the first frame update
    public void Play() // Startet die angegebene Szene und übergibt den eingetippten Spielernamen
    {
        SceneManager.LoadScene("MainScene");
        Name.playerNameString = playerName.text;
    }

    public void Restart() // Wenn das Spiel mit einem neuen Namen gestartet werden will, dann startet es bei der Namenseingabe
    {
        SceneManager.LoadScene("StartScene");
    }
}
