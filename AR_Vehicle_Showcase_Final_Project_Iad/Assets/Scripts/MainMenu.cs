using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public CanvasGroup OptionPanel;

    public void MarkerLessExperience()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MarkerBasedExperienc()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }



    public void QuitGame()
    {
        Application.Quit();

    }
}