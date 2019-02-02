using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject optionMenu;
    public static bool GameIsPaused = true;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        optionMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
