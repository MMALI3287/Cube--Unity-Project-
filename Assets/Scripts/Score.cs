using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerPosition.position.z.ToString("0");

    }
}
