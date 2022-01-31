using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public float timer = 60;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() // Der Timer zählt von 60 Sekunden abwärts.
    {
        timer -= Time.deltaTime;
        timeText.text = timer.ToString("F0");

        if (timer < 0) // Wenn er 0 erreicht endet das Spiel
        {
            SceneManager.LoadScene("EndScene");
            Score.playerScoreString = CandyCollision.count.ToString();
        }
    }
}
