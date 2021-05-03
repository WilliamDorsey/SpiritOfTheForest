using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;

            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        }
    }
}
