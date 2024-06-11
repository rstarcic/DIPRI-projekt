using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previousSceneCheck : MonoBehaviour
{
    public GameObject PlayerHallway;
    public GameObject PlayerParentsRoom;
    public GameObject PlayerAttic;
    public GameObject PlayerDoughterRoom;
    public GameObject PlayerWC;
    public GameObject PlayerSonRoom;
    // Start is called before the first frame update
    void Start()
    {
        int previousScene = PlayerPrefs.GetInt("previousScene");
        Debug.Log(previousScene);
        if(previousScene==3)
        {
            PlayerHallway.SetActive(true);
            PlayerParentsRoom.SetActive(false);
            PlayerAttic.SetActive(false);
            PlayerDoughterRoom.SetActive(false);
            PlayerWC.SetActive(false);
            PlayerSonRoom.SetActive(false);
        }
        else if(previousScene==8)
        {
            PlayerHallway.SetActive(false);
            PlayerParentsRoom.SetActive(true);
            PlayerAttic.SetActive(false);
            PlayerDoughterRoom.SetActive(false);
            PlayerWC.SetActive(false);
            PlayerSonRoom.SetActive(false);
        }
        else if(previousScene==6)
        {
            PlayerHallway.SetActive(false);
            PlayerParentsRoom.SetActive(false);
            PlayerAttic.SetActive(false);
            PlayerDoughterRoom.SetActive(false);
            PlayerWC.SetActive(false);
            PlayerSonRoom.SetActive(true);
        }
        else if(previousScene==7)
        {
            PlayerHallway.SetActive(false);
            PlayerParentsRoom.SetActive(false);
            PlayerAttic.SetActive(false);
            PlayerDoughterRoom.SetActive(true);
            PlayerWC.SetActive(false);
            PlayerSonRoom.SetActive(false);
        }
        else if(previousScene==9)
        {
            PlayerHallway.SetActive(false);
            PlayerParentsRoom.SetActive(false);
            PlayerAttic.SetActive(false);
            PlayerDoughterRoom.SetActive(false);
            PlayerWC.SetActive(true);
            PlayerSonRoom.SetActive(false);
        }
        else if (previousScene == 10)
        {
            PlayerHallway.SetActive(false);
            PlayerParentsRoom.SetActive(false);
            PlayerAttic.SetActive(true);
            PlayerDoughterRoom.SetActive(false);
            PlayerWC.SetActive(false);
            PlayerSonRoom.SetActive(false);
        }
    }

    
}
