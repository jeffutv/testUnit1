using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamswitchP2 : MonoBehaviour
{
    public GameObject cam12;
    public GameObject cam22;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("12key"))
        {
            cam12.SetActive(false);
            cam22.SetActive(true);
        }

        if (Input.GetButtonDown("22key"))
        {
            cam12.SetActive(true);
            cam22.SetActive(false);
        }
    }
}
