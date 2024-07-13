using UnityEngine.UI;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
            Load();
        }
        
        else 
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
    }

    public void GoBack()
    {
        Application.LoadLevel("Menu");
    }


}

