using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_destroy : MonoBehaviour
{
    AudioSource Audio;
    public AudioClip DestorySound;

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
            PlayClip(DestorySound);
            GameObject.Find("StartHere").gameObject.SetActive(false);
        }
    }

    void PlayClip(AudioClip clip)
    {
        Audio.clip = clip;
        Audio.Play();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
