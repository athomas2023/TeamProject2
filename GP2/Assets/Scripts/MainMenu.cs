using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(//Name of Game Scene Here//
        );
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
