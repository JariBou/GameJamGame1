using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenes/Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
