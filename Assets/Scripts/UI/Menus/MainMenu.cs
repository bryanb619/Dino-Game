using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject _MenuOptions, _MenuMain;


     // first buttons to be selected 
    [SerializeField] private GameObject StartFirst ,OptionsFirst; 


    private void Start()
    {
        Time.timeScale = 1f; 
        _MenuMain.SetActive(true);
        _MenuOptions.SetActive(false);
    }

    // Start menu buttons

    // play 
    public void PlayButton()
    {
        //Load Game scene (start game)
        SceneManager.LoadScene("LevelScene");
    }

    // options
    public void OptionButton()
    {
        // Set main to false
        _MenuMain.SetActive (false);

        // set options to true
        _MenuOptions.SetActive (true);

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(OptionsFirst); 



    }
    // quit
    public void QuitButton ()
    {   
        // Quit game
        Application.Quit();
        // 
        Debug.Log("Game whas Quitted");
    }

    
    // Options Menu buttons


    // back to main menu button
    public void BackButton()
    {

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(StartFirst);
        // Set options to false
        _MenuOptions.SetActive(false);

        // set main to true
        _MenuMain.SetActive(true);
    }
}
