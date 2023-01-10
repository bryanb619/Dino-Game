using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PauseMenu : MonoBehaviour
{

    // Variables 

    // game paused bool
    [HideInInspector]
    public bool _Paused = false;

    //  UI Canvas
    [SerializeField]
    public GameObject PauseCanvas, _pauseMenu, _OtptionsMenu;

    [SerializeField] private GameObject _Claw;

    private float SlideValue;

    public Slider DinoSpawnSlider;

    public DinoSpawner dinoSpawnScript;

    // Event Sy




    private void Start()
    {

        dinoSpawnScript = FindObjectOfType<DinoSpawner>();

        PauseCanvas.SetActive(true);
        _pauseMenu.SetActive(false);
        _OtptionsMenu.SetActive(false);
        _Claw.SetActive(true);

        DataCheck();

    }

    // Update is called once per frame
    void Update()
    {

        KeyDetect();
        
    }


    private void DataCheck()
    {
        if (PlayerPrefs.HasKey("Spawn Rate"))
        {
            PlayerPrefs.SetFloat("Spawn Rate", 2f);
        }
        else
            Load();
    }


    public void DestroyMenu()
    {
        Destroy(gameObject);
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
        if (Input.GetButtonDown("Pause"))
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
        _Claw.SetActive(true);

        Time.timeScale = 1f;

        _Paused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.Locked;



    }
    // method pause
    public void Pause()
    {


        _pauseMenu.SetActive(true);
        _Claw.SetActive(false);

        Time.timeScale = 0f;

        _Paused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // buttons 

    // Pause Menu
    public void ResumeButton()
    {

        Resume();
    }

    // OPTIONS
    public void OptionsButton()
    {
        _OtptionsMenu.SetActive(true);
    }

    public void SliderSpawnRate()
    {


        SlideValue = DinoSpawnSlider.value;


        if(SlideValue >= 8)
        {
            dinoSpawnScript.SpawnRate = 2;

        }
        else if (SlideValue >= 6)
        {
            dinoSpawnScript.SpawnRate = 4;
        }
        else if (SlideValue >= 4)
        {
            dinoSpawnScript.SpawnRate = 6;
        }
        else if (SlideValue >= 2)
        {
            dinoSpawnScript.SpawnRate = 8;
        }
        else if (SlideValue >= 1)
        {
            dinoSpawnScript.SpawnRate = 10;
        }
        Save();
        
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



    // Saved data

    private void Load()
    {
        DinoSpawnSlider.value = PlayerPrefs.GetFloat("Spawn Rate");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Spawn Rate", DinoSpawnSlider.value);

    }
}