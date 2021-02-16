using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFirst : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-3.52f, 1.93f, 1.37f);

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
