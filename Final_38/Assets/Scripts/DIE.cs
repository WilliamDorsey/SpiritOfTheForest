using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene("HUB Level", LoadSceneMode.Single);
            //Put send back to hub here
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
