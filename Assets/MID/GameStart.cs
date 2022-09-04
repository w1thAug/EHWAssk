using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    AudioSource Audio;

    void Init()
    {
        Audio = GetComponent<AudioSource>();
        Audio.loop = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
        PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio()
    {
        Audio.Play();
    }

    public void ButtonClick()
    {
        Debug.Log("Next Scene");
        SceneManager.LoadScene("MID01");
    }
}
