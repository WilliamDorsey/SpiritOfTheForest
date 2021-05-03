using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button Startbutton;

    void Start()
    {
        Button btn = Startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

