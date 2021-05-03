using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HubPortalScript : MonoBehaviour
{
    public int levelDest;
    private string levelName;

    private bool inBounds = false;
    public Text interact;

    // Start is called before the first frame update
    void Start()
    {
        interact.text = "";

        if (levelDest == 1) levelName = "Level 1";
        else if (levelDest == 2) levelName = "Level 2";
        else if (levelDest == 3) levelName = "Level 3";
        else Debug.Log("Error: Invalid level number.");
    }

    // Update is called once per frame
    void Update()
    {
        if (inBounds && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName); ;
        }
    }

    private void OnTriggerEnter(Collider co)
    {
        if (co.gameObject.tag == "Player")
        {
            inBounds = true;
            interact.text = "Press 'E' to enter " + levelName;
            if (levelName == "Level 2.5") interact.text = "Press 'E' to enter Level 2";
        }
    }

    private void OnTriggerExit(Collider co)
    {
        if (co.gameObject.tag == "Player")
        {
            inBounds = false;
            interact.text = "";
        }
    }
}
