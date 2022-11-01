using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        if (PlayerPrefs.HasKey("AudioVolume"))
        {
            PlayerPrefs.SetFloat("AudioVolume", 0.5f);
        }
        else
            Load();
    }


    public void ChangeVolume()
    {
        AudioListener.volume = _slider.value;
        Save();
    }

    private void Load()
    {
        _slider.value = PlayerPrefs.GetFloat("AudioVolume");
    }

   private void Save()
   {
        PlayerPrefs.SetFloat("AudioVolume", _slider.value);

   }
}
