using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button Quit;

// Start is called before the first frame update
    void Start()
    {
        Button btn = Quit.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
    }
}

