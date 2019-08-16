using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPoint : MonoBehaviour
{
    PlayerController playerController;
    void Start()
    {
        playerController = GameObject.Find("cat").gameObject.GetComponent<PlayerController>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "platforms")
        {
            playerController.isGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "platforms")
        {
            playerController.isGround = false;
        }
    }
}
