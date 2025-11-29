using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        FindObjectOfType<ScoreManageer>().SavedCoins();
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);

        FindObjectOfType<ScoreManageer>().SavedCoins();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<ScoreManageer>().SavedCoins();
    }
}