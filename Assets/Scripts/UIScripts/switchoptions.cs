using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchoptions : MonoBehaviour
{
    public void onExit()
    {
        Application.Quit();
    }

    public void onStart()
    {
        SceneManager.LoadScene(1);
    }

    public void onRestart()
    {
        SceneManager.LoadScene(0);
    }
}
