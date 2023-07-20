using UnityEngine;
using UnityEngine.UI;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        DataCheck();
    }

  
    private void DataCheck()
    {
        if (!PlayerPrefs.HasKey("GameVolume"))
        {
            PlayerPrefs.SetFloat("GameVolume", 0.7f);
        }
        else
        {
            Load();
        }
            
    }

    public void ChangeVolume()
    {
        float volume = _slider.value;

        Save(volume);
        
    }

    private void Load()
    {
        _slider.value = PlayerPrefs.GetFloat("GameVolume");
    }

   private void Save(float volume)
   {
       AudioListener.volume = volume;
       
        PlayerPrefs.SetFloat("GameVolume",AudioListener.volume);
        
#if UNITY_EDITOR
        Debug.Log("Game Volume: " + AudioListener.volume);
       
#endif

   }
}
