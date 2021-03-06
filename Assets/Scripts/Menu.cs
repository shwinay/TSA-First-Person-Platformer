﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void switchScenes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void switchToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        PlayerController.score = 0;
    }

    public void switchToInstructions()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 2);
    }

    public void switchToPreviousScene()
    {
        SceneManager.LoadScene(PlayerController.continueScene);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
