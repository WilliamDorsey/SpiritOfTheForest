using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomKill : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Plant")
        {
            Destroy(other.gameObject);
        }
    }
}
