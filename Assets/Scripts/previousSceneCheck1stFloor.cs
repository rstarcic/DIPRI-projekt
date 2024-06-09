using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previousSceneCheck1stFloor : MonoBehaviour
{
   
    public GameObject PlayerStart;
    public GameObject PlayerKitchen;
    public GameObject Player2ndFloor;
    
    // Start is called before the first frame update
    void Start()
    {
        int previousScene = PlayerPrefs.GetInt("previousScene");
        Debug.Log(previousScene);
        
        if(previousScene==4)
        {
            PlayerStart.SetActive(false);
            PlayerKitchen.SetActive(true);
            Player2ndFloor.SetActive(false);
            
        }
        else if(previousScene==5)
        {
            PlayerStart.SetActive(false);
            PlayerKitchen.SetActive(false);
            Player2ndFloor.SetActive(true);
           
        }
        else
        {
            PlayerStart.SetActive(true);
            PlayerKitchen.SetActive(false);
            Player2ndFloor.SetActive(false);
            
        }
        
       
    }

    
}


