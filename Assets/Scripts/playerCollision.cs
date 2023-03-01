
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<AudioManager>().Play("Crash");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
