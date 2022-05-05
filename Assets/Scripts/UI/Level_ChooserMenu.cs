using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_ChooserMenu : MonoBehaviour
{
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

}
