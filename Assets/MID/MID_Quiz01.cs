using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_Quiz01 : MonoBehaviour
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
            GameObject.Find("OnCube01").transform.Find("QuizCanvas").gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("QuizCanvas").gameObject.SetActive(false);
        }
    }
}
