using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CandyCollision : MonoBehaviour
{
    public static int count;
    public Text score;
    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        score.text = "Eingesammelt: " + count.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision) // Wenn ein Geldsack Iron Man berührt geht der Zähler 1 nach oben. Bei einer Berührung mit einer Rakete verschwindet einer der Arc-Reaktoren
    {
        if (collision.gameObject.tag == "Candy")
        {
            count++;
            score.text = "Eingesammelt: " + count.ToString();
        }

        if (collision.gameObject.tag == "Missile")
        {
            if (heartOne.activeSelf)
            {
                heartOne.SetActive(false);
            }
            else if (heartTwo.activeSelf)
            {
                heartTwo.SetActive(false);
            }
            else
            {
                heartThree.SetActive(false);
                SceneManager.LoadScene("EndSceneLost");
            }
        }
    }
}
