using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject gameIntroMenu;
  

    private void Start()
    {
        if (PlayerPrefs.GetInt("level") > 0)
        {
            gameIntroMenu.SetActive(false);
        }
    }

    public void closegame()
    {
        Application.Quit();
    }

    public void reloadscene()
    {
        PlayerPrefs.SetInt("level", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
