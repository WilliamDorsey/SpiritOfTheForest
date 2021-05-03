using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finalWinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject portal1;
    public GameObject portal2;
    public GameObject portal3;
    private bool inBounds = false;
    public Text interact;

    // Start is called before the first frame update
    void Start()
    {
        interact.text = "";

        if(TheOverlord.Level1 > 0)
        {
            Destroy(portal1);
        }

        if(TheOverlord.Level2 > 0)
        {
            Destroy(portal2);
        }

        if(TheOverlord.Level3 > 0)
        {
            Destroy(portal3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inBounds && Input.GetKey("e"))
        {
            if(TheOverlord.Win)
            {
                SceneManager.LoadScene("CutScene", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("Tutorial Level", LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter(Collider co)
    {
        if (co.gameObject.tag == "Player")
        {
            inBounds = true;
            if(TheOverlord.Win)
            {
                interact.text = "Press 'E' to create cure";
            }
            else
            {
                interact.text = "Press 'E' for tutorial";
            }
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

    /*private void OnTriggerEnter(Collider co)
    {
        if (co.gameObject.tag == "Player")
        {
            if(TheOverlord.Win)
            {
                SceneManager.LoadScene("CutScene", LoadSceneMode.Single);
            }
            else
            {

            }
        }
    }*/
}
