using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTPScript : MonoBehaviour
{
    public Transform destination;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player collided with log!");
            player.transform.position = destination.transform.position;
        }
    }
}
