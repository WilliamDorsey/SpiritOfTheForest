using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            HealthScript.lives--;
        }
    }
}
