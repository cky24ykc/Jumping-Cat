using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Retry()
    {
        PlayerController.time = 0;
        SceneManager.LoadScene("GameScene");
    }
}
