using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public static int lives = 3;
    Text livesText;
    public Text victoryText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        victoryText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            lives = 0;
            victoryText.text = "YOU LOSE";
        }
    }
}
