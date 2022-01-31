using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() // Wenn die Pfeiltasten oder A-D-Tasten verwendet werden bewegt sich der Spieler
    {
        float inputX = Input.GetAxis("Horizontal");
        player.transform.position = player.transform.position + Vector3.right * inputX * moveSpeed * Time.deltaTime;
    }
}