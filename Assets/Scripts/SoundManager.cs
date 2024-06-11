using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volume;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 0.5f);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volume.value;
        Save();
    }
    public void Load()
    {
        volume.value = PlayerPrefs.GetFloat("volume");
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("volume", volume.value);
    }
}
