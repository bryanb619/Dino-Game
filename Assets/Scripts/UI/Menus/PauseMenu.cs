using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Variables 

    // game paused bool 
    public static bool Paused = false;

    //  Pause Menu Canvas
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {

        KeyDetect();
        

    }

    private void KeyDetect()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    // method Resume
    void Resume()
    {

        pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        Paused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = CursorLockMode.Locked;



    }
    // method pause
    void Pause()
    {


        pauseMenu.SetActive(true);

        Time.timeScale = 0f;

        Paused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;


    }

    // buttons
    public void Resumeutton()
    {

        pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        Paused = false;

    }

    public void MenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
        Debug.Log("Scene Loaded");

    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is terminated");
    }
}