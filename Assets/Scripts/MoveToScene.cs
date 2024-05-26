using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
   

    public void Move(int sceneID)
    {
        SceneManager.LoadScene(sceneID,LoadSceneMode.Single);

    }
}
