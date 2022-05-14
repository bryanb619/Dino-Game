using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_ChooserMenu : MonoBehaviour
{

    //  Menu Game Object
    [Header("Menus config")]
    [SerializeField]
    private GameObject MainLevelChooser, Menu1, Menu2, Menu3;

    // new menu voids

    public void Menu_1()
    {
        MainLevelChooser.SetActive(false);
        Menu1.SetActive(true);

    }

    public void Menu_2()
    {
        MainLevelChooser.SetActive(false);
        Menu2.SetActive(true);
    }

    public void Menu_3()
    {
        MainLevelChooser.SetActive(false);
        Menu3.SetActive(true);

    }

    public void BackToMenu()
    {
        MainLevelChooser.SetActive(true);

        Menu1.SetActive(false);
        Menu2.SetActive(false);
        Menu3.SetActive(false);
    }


    // Level buttons

    public void Level_1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_4()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_5()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_6()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_7()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_8()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level_9()
    {
        SceneManager.LoadScene("Scene1");
    }


    /* OLD CONFIG


    // Cafe level
    public void CafeButton()
    {
        // load cafe
        SceneManager.LoadScene("Level_Caffee");

    }

    // Magic forest level
    public void MagicForestButton()
    {
        // load Magic forest
        SceneManager.LoadScene("Level_MagicForest_Sprite");

    }

    // Jungle level
    public void JungleButton()
    {
        // load Magic forest
        SceneManager.LoadScene("Level_Jungle");

    }
    // Button 4 PIRATES
    public void IslandButton()
    {
        SceneManager.LoadScene("Level_Island");
    }

    // Button 5 Dungeon
    public void DungeonButton()
    {
        SceneManager.LoadScene("Level_Dungeon");
    }

    // Button 6 Western
    public void WesternButton()
    {
        SceneManager.LoadScene("Level_Western");
    }



    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
    */
}
