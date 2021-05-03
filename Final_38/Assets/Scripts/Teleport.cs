using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{

   public AudioSource musicSource;
   public AudioClip Wrap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        void OnTriggerEnter(Collider other)
        {
        if (other.tag == "WarpF1")
        {
            transform.position = new Vector3(0, 0, 0);
            musicSource.clip = Wrap;
            musicSource.Play();
        }
        
        

        }
        

        
    
}
