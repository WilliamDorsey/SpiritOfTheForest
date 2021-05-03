using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingScript : MonoBehaviour
{
    public int max;
    float increase = 0.03f;
    int count = 0;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= 0.01f;
        audio = GetComponent<AudioSource>();
        audio.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(count < max)
        {
            transform.localScale += new Vector3(increase, increase, increase);
            count++;
        }
        else
        {
            audio.Pause();
        }
    }
}
