using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    GameObject background;
    bool start = false;

    void Start()
    {
        player = GameObject.Find("cat");
        background = GameObject.Find("background");
    }

    
    void Update()
    {
        if (player.transform.position.y > transform.position.y) start = true;
        if (start)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }
        background.transform.position = new Vector3(0, transform.position.y, 0);
    }

    
}
