using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Variables 

    // game paused bool
    [HideInInspector]
    public bool _Paused = false;

    //  Pause Menu Canvas
    [SerializeField]
    public GameObject  PauseCanvas,_pauseMenu, _OtptionsMenu;

    private void Start()
    {
        PauseCanvas.SetActive(true);
        _pauseMenu.SetActive(false);
        _OtptionsMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        KeyDetect();
 
    }

    void FixedUpdate()
    {
        if (!_Paused)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }
        if (_Paused == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        
    }

    private void KeyDetect()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_Paused)
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
    public void Resume()
    {

        _pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        _Paused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = CursorLockMode.Locked;



    }
    // method pause
    public void Pause()
    {


        _pauseMenu.SetActive(true);

        Time.timeScale = 0f;

        _Paused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // buttons 

    // Pause Menu
    public void ResumeButton()
    {

        _pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        _Paused = false;

    }

    // OPTIONS
    public void OptionsButton()
    {
        _OtptionsMenu.SetActive(true);
    }

    // EXIT
    public void ExitButton()
    {
        //Application.Quit();
        Debug.Log("Star Menu Loaded");
        SceneManager.LoadScene("StartMenu");
    }

    // Options Menu

    // BACK BUTTON

    public void BakcButton()
    {
        _pauseMenu.SetActive(true);
        _OtptionsMenu.SetActive(false);

    }


    // FUTHER OPTIONS
}