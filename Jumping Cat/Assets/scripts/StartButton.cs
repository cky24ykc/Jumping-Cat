using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void MyStart()
    {
        PlayerPrefs.GetFloat("BestTime");
        SceneManager.LoadScene("GameScene");
    }
}
