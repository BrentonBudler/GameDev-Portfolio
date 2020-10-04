using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuUi;
    public GameObject deadMenuUi;
    public GameObject wonMenuUi;
    public GameObject torch;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

   public void Resume()
    {
        torch.SetActive(true);
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        torch.SetActive(false); 
        Time.timeScale = 0f;
        GamePaused = true; 
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(0); 
    }

    public void LoadDead()
    {

        Time.timeScale = 0f;
        deadMenuUi.SetActive(true);
    }

    public void LoadWon()
    {

        Time.timeScale = 0f;
        wonMenuUi.SetActive(true);
    }


    public void LoadGame()
    {
        torch.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        Debug.Log("LOADED");
        deadMenuUi.SetActive(false);
        wonMenuUi.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }

}
