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
    void Update()
    {
        timer -= Time.deltaTime;
        timeText.text = timer.ToString();

        if (timer < 0)
        {
            SceneManager.LoadScene("EndScene");
            Name.playerScoreString = CandyCollision.count.ToString();
        }
    }
}
