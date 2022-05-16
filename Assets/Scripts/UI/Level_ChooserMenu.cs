using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_ChooserMenu : MonoBehaviour
{

    //  Menu Game Object
    [Header("Menu")]
    [SerializeField]
    private GameObject MainLevelChooser, Menu1, Menu2, Menu3;


    [Header("Back Buttons")]
    [SerializeField]
    private GameObject BackButtonInMENUS,BackToStart;


    // FAIL SAFE CODE
    public void Start()
    {
        MainLevelChooser.SetActive(true);

        Menu1.SetActive(false);
        Menu2.SetActive(false);
        Menu3.SetActive(false);

        BackButtonInMENUS.SetActive(false);

    }

    // Normal Code

    public void Menu_1() // Level Nature Chooser
    {
        MainLevelChooser.SetActive(false);
        Menu1.SetActive(true);

        BackButtonInMENUS.SetActive(true);
    }

    public void Menu_2() // Level Desert Chooser
    {
        MainLevelChooser.SetActive(false);
        Menu2.SetActive(true);

        BackButtonInMENUS.SetActive(true);
    }

    public void Menu_3() // Level Halloween Chooser
    {
        MainLevelChooser.SetActive(false);
        Menu3.SetActive(true);

        BackButtonInMENUS.SetActive(true);
    }

    // In Menus back button
    public void BackToMenu()
    {
        if (Menu1 == true || Menu2 == true || Menu3 == true)
        {

            Menu1.SetActive(false);
            Menu2.SetActive(false);
            Menu3.SetActive(false);

            BackButtonInMENUS.SetActive(false);

            MainLevelChooser.SetActive(true);
        }
        
    }

    // Main Menu Scene BAck Button
    public void BackToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }


    // Level buttons

    // LEVEL NATURE
    public void Level_1()
    {
        SceneManager.LoadScene("Level_1_Nature");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Level_2_Nature");
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Level_3_Nature");
    }

    // LEVEL DESERT

    public void Level_4()
    {
        SceneManager.LoadScene("Level_1_Desert");
    }

    public void Level_5()
    {
        SceneManager.LoadScene("Level_2_Desert");
    }

    public void Level_6()
    {
        SceneManager.LoadScene("Level_3_Desert");
    }

    // LEVEL HALLOWEEN

    public void Level_7()
    {
        SceneManager.LoadScene("Level_1_Halloween");
    }

    public void Level_8()
    {
        SceneManager.LoadScene("Level_2_Halloween");
    }

    public void Level_9()
    {
        SceneManager.LoadScene("Level_3_Halloween");
    }

    // END OF CODE
}
