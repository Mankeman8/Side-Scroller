﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverUI : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
