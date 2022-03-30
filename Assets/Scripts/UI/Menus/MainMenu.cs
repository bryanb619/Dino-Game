using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject _MenuOptions; // Menu options
    public GameObject _MenuMain; // Main Menu


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
        // Set options to false
        _MenuOptions.SetActive(false);

        // set main to true
        _MenuMain.SetActive(true);
    }
}
