using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}