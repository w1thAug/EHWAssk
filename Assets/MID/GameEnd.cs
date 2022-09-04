using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
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
        ExitGame();
    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
