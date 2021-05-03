using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasueButton : MonoBehaviour
{

    public GameObject pauseMenu;
    public bool isPause;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void Hub()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HUB Level");
    }
}
