using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuQuality : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Dropdown qualitySettings;
    int index;    

    public void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index, false);
        PlayerPrefs.SetInt("quality", index);
        
    }
void Start()
    {
        if(!PlayerPrefs.HasKey("quality"))
        {
            PlayerPrefs.SetInt("quality", 3);
            QualitySettings.SetQualityLevel(3, false);
            qualitySettings.value=3;
        }
        else
        {
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("quality"), false);
            qualitySettings.value=PlayerPrefs.GetInt("quality");
        }
    }

}
