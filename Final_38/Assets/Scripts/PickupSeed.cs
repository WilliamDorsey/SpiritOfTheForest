using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSeed : MonoBehaviour
{
    //public AudioSource audioData;

    void Start()
    {
        //audioData = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision co)
    {
        if (co.gameObject.tag == "Acorn")
        {
            this.GetComponent<SeedThrower>().ammoAcorn++;
            Destroy(co.gameObject);
            //audioData.Play(0);
            Debug.Log("Seed picked up!");
        }
        else if (co.gameObject.tag == "Grow")
        {
            this.GetComponent<SeedThrower>().ammoGrow++;
            Destroy(co.gameObject);
            //audioData.Play(0);
            Debug.Log("Seed picked up!");
        }
        else if (co.gameObject.tag == "Hurt")
        {
            this.GetComponent<SeedThrower>().ammoHurt++;
            Destroy(co.gameObject);
            //audioData.Play(0);
            Debug.Log("Seed picked up!");
        }
        else
        {
            Debug.Log("Error: Seed tag not found.");
        }
        this.gameObject.GetComponent<SeedThrower>().UpdateWeapons();
    }

    private void OnTriggerEnter(Collider co)
    {
        if (co.gameObject.tag == "Pickup")
        {
            //audioData.Play(0);
            this.GetComponent<SeedThrower>().ammoHurt += 10;
            this.GetComponent<SeedThrower>().ammoGrow += 10;
            this.GetComponent<SeedThrower>().ammoAcorn += 10;
            Destroy(co.gameObject);
            this.gameObject.GetComponent<SeedThrower>().UpdateWeapons();
        }
    }
}
