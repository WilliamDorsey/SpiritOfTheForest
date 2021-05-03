using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public Button Creditsbutton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = Creditsbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Credits");
    }
}
