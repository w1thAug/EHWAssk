using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MID_Quiz03 : MonoBehaviour
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
            GameObject.Find("Ending").transform.Find("LastCanvas").gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("LastCanvas").gameObject.SetActive(false);
        }
    }
}
