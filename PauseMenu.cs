using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool openPM = false;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape) && GameManager.gameIsPaused == false) || openPM == true)
        {
            if (GameManager.gameIsPaused)
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameManager.gameIsPaused = false;
        
    }

    void Pause()
    {
        openPM = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameManager.gameIsPaused = true;
    }

    public void Controls()
    {
        pauseMenuUI.SetActive(false);
        ControlsMenu.openCM = true;
    }

    public void mainMenu()
    {
        Time.timeScale = 1f;
        GameManager.gameIsPaused = false;
        SceneManager.LoadScene("Main Menu");
    }
}
