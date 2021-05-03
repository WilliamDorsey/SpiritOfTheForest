using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Text winText;
    static float timer;
    private bool win;


    // Start is called before the first frame update
    void Start()
    {
        win = false;
        winText.text = "";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Update is called once per frame
    void Update()
    {
        if(win == false)
        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

        string time = "";

        if (!win) timerText.text = time;

        if (Input.GetKeyDown("r"))
        {
            timer = 0.0f;
            RestartGame();
        }
        if (Input.GetKeyDown("e") && win)
        {
            SceneManager.LoadScene("HUB Level", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            win = true;
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            if(sceneName == "Level 1")
            {
                TheOverlord.Level1 = 1;
            }
            else if(sceneName == "Level 2")
            {
                TheOverlord.Level2 = 1;
            }
            else if(sceneName == "Level 3")
            {
                TheOverlord.Level3 = 1;
            }
            winText.text = "Level Complete!";
            timerText.text = "Press 'E' to continue";
            //Put send back to hub here
        }
    }
}
