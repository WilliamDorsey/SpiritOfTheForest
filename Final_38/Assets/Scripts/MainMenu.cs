using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button Startbutton;

    void Start()
    {
        Button btn = Startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        if (SceneManager.GetActiveScene().name == "Win Screen")
        {
            TheOverlord.Level1 = 0;
            TheOverlord.Level2 = 0;
            TheOverlord.Level3 = 0;
        }
        SceneManager.LoadScene("Main Menu");
    }
}

