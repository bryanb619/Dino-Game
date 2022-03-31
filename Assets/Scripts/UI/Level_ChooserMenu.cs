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
        SceneManager.LoadScene("Level_MagicForest");

    }

    // Jungle level
    public void JungleButton()
    {
        // load Magic forest
        SceneManager.LoadScene("Level_Jungle");

    }



    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
