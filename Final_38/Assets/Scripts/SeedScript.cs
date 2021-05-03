using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedScript : MonoBehaviour
{
    public GameObject plant;
    public GameObject tree;
    public GameObject spore;
    public Rigidbody rb;


    Vector3 velocity;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter (Collision co)
    {
        if (co.gameObject.tag == "Earth")
        {
            if (this.tag == "Acorn")
            {
                Plant(plant);
            }
            else if (this.tag == "Grow")
            {
                Plant(tree);
            }
            else if (this.tag == "Hurt")
            {
                Plant(spore);
            }
            else
            {
                Debug.Log("Error: Seed tag not found.");
            }
            Destroy (gameObject);
        }
        if (co.gameObject.tag == "Enemy" && this.tag == "Acorn")
        {
            if (co.gameObject.name == "Ranged Enemy") co.gameObject.GetComponent<RangedEnemyAIScript>().Stunned();
            else if (co.gameObject.name == "Melee Enemy") co.gameObject.GetComponent<MeleeEnemyAIScript>().Stunned();
            else Debug.Log("Error: Unknown enemy type or name");
            Destroy(gameObject);
        }
        else
        {
            //Enter bouncing sound effect
        }
    }

    void Plant(GameObject obj)
    {
        var projectileObj = Instantiate(obj, transform.position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0))) as GameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bouncy")
        {
            velocity = rb.velocity;
            velocity.y = Mathf.Abs(velocity.y);
            rb.velocity = velocity;
        }
    }
}
