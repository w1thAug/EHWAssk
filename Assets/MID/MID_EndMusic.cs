using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_EndMusic : MonoBehaviour
{

    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayAudio();
        }
    }

    void PlayAudio()
    {
        Audio.Play();
    }
}
