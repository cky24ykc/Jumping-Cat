using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text timeText;
    public Text BestTimeText;

    void Start()
    {
        timeText.text = "Time:" + PlayerController.time.ToString("#0.00");
        BestTimeText.text = "Your Best Time:" + PlayerController.besttime.ToString("#0.00");
    }
}
