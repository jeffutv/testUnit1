﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFirst2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(3.75f, 1.92f, 1.64f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
