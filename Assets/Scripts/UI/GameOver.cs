using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void  Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale =1;
    }

    public void   Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
