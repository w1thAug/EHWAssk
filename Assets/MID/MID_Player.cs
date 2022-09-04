using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MID_Player : MonoBehaviour
{

    AudioSource Audio;
    public AudioClip EndingSound;

    public Transform Correct01;
    public Transform Correct02;

    public Transform Wrong01;
    public Transform Wrong02;

    void Init()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RideTrigger")
        {
            Transform ObjectToRide = other.transform.parent;
            transform.parent = ObjectToRide;
        }

        else if (other.tag == "LeftQuiz01")
        {
            transform.position = Wrong01.position;
            GameObject.Find("Stair01").transform.Find("WrongCanvas").gameObject.SetActive(true);
            Invoke("DestroyWrong", 3f);
        }

        else if(other.tag == "RightQuiz01")
        {
            transform.position = Correct01.position;
        }

        else if (other.tag == "RightQuiz02")
        {
            transform.position = Wrong01.position;
            GameObject.Find("Stair01").transform.Find("WrongCanvas").gameObject.SetActive(true);
            Invoke("DestroyWrong", 3f);
        }

        else if (other.tag == "LeftQuiz02")
        {
            transform.position = Correct02.position;
        }

        else if (other.tag == "End")
        {
            GameObject.Find("Ending").transform.Find("Yellow").gameObject.SetActive(false);
            GameObject.Find("Ending").transform.Find("Green").gameObject.SetActive(false);
            GameObject.Find("Ending").transform.Find("Pink").gameObject.SetActive(false);
            GameObject.Find("Ending").transform.Find("RealEnd").gameObject.SetActive(true);
            GameObject.Find("Ending").transform.Find("Heart").gameObject.SetActive(true);
        }

        else if (other.tag == "Wrong")
        {
            transform.position = Wrong02.position;
            GameObject.Find("OnCube05").transform.Find("LuckCanvas").gameObject.SetActive(true);
            Invoke("DestroyWrong02", 3f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "RideTrigger")
        {
            transform.parent = null;
        }
    }

    void DestroyWrong()
    {
        GameObject.Find("Stair01").transform.Find("WrongCanvas").gameObject.SetActive(false);
    }

    void DestroyWrong02()
    {
        GameObject.Find("OnCube05").transform.Find("LuckCanvas").gameObject.SetActive(false);
    }
}
