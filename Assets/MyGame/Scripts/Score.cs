using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static string playerScoreString;

    public Text playerScoreText;

    // Start is called before the first frame update
    void Start() // Der Name und das Ergebnis des Spieles wird an diese Methode übergeben und kann damit in allen Szenen verwendet werden
    {
        playerScoreText.text = playerScoreString;
    }
}
