using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camswitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1key")) 
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

        if (Input.GetButtonDown("2key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

    }
}
