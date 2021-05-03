using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button Startbutton;

    void Start()
    {
        Button btn = Startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(TheOverlord.LastScene);
    }
}

