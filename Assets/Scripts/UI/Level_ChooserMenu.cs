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

    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
