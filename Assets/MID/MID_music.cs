using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_music : MonoBehaviour
{
    AudioSource Audio;

    void Init()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    void OnTriggerEnter(Collider other)
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

    // Update is called once per frame
    void Update()
    {

    }
}
