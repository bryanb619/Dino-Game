using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

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
    
    public Slider DinoSpawnSlider;

    public DinoSpawner dinoSpawnScript;

    [SerializeField] GameObject FirstChoose, OptionsChoose; 
    // Event


    private void Awake()
    {
        DataCheck();
    }

    private void Start()
    {
        
    }
    


    // Update is called once per frame



    private void DataCheck()
    {
        dinoSpawnScript = FindObjectOfType<DinoSpawner>();

        Time.timeScale = 1f; 
        PauseCanvas.SetActive(true);
        _pauseMenu.SetActive(false);
        _OtptionsMenu.SetActive(false);
        _Claw.SetActive(true);
        
        
        if (!PlayerPrefs.HasKey("rateOfDinoSpawn"))
        {
            PlayerPrefs.SetFloat("rateOfDinoSpawn", 5f);
#if UNITY_EDITOR                                

            Debug.Log("No Save found, Spawn rate is now: " + dinoSpawnScript.spawnRate);
#endif
        }
        else
        {
            Load();
        }
           
    }
    
    void Update()
    {
        KeyDetect();

#if UNITY_EDITOR
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteAll();
            print("all data deleted");
        }
#endif
        
        
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
        if (_Paused)
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
        EventSystem.current.SetSelectedGameObject(null);
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

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(FirstChoose);

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
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(OptionsChoose);
    }

    public void SliderSpawnRate()
    {
        float value = DinoSpawnSlider.value;
        
        Save((int)value);
        
        
#if UNITY_EDITOR
        
        Debug.Log("Slider Value: " + DinoSpawnSlider.value);
#endif
        
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

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(FirstChoose);

    }


    // FUTHER OPTIONS

    
    private void Load()
    {
        dinoSpawnScript.spawnRate = PlayerPrefs.GetFloat("rateOfDinoSpawn");
        
#if UNITY_EDITOR                                

            Debug.Log("Save found, Spawn rate is now: " + dinoSpawnScript.spawnRate);
#endif
        
    }

    // Saved data
    private void Save(int value)
    {
        dinoSpawnScript.spawnRate = value;
        
        PlayerPrefs.SetFloat("rateOfDinoSpawn",  value);

    }
}