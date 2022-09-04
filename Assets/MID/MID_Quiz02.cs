using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_Quiz02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("OnCube03").transform.Find("QuizCanvas02").gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("QuizCanvas02").gameObject.SetActive(false);
        }
    }
}
