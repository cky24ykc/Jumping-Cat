using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        timeText.text = "time:" + PlayerController.time.ToString("#0.00");
    }
}
