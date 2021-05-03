using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShot : MonoBehaviour
{
  
   

                                                   // Holds a reference to the first person camera
   
   // public AudioSource fireAudio;                                        // Reference to the audio source which will play our shooting sound effec
    public GameObject projectile;
    public Transform SpawnTransform;

    public float bulletSpeed = 10;

    void Start()
    {
        

        // Get and store a reference to our AudioSource component
        //fireAudio = GetComponent<AudioSource>();

        // Get and store a reference to our Camera by searching this GameObject and its parents
       // fpsCam = GetComponentInParent<Camera>();
    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {


            



            GameObject bullet = Instantiate(projectile, SpawnTransform.position, SpawnTransform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

          

            //fireAudio.Play();
        }
    }
      
}
