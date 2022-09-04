using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_How : MonoBehaviour
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
            GameObject.Find("StartHere").transform.Find("HowCanvas").gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("HowCanvas").gameObject.SetActive(false);
        }
    }
}
