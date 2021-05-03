using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBoxScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            TheOverlord.LastScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Lose Screen");
        }
        
    }
}
