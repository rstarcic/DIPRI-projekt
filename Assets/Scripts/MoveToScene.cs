using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
   
    public Animator fade;

    public void Move(int sceneID)
    {
        PlayerPrefs.SetInt("previousScene", SceneManager.GetActiveScene().buildIndex);
        fade.SetTrigger("SceneChanged");
        SceneManager.LoadScene(sceneID,LoadSceneMode.Single);
    }
}
