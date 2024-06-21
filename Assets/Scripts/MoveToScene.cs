using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public Animator fade;
    public AudioSource audioSource; 
    public AudioClip doorSound;

    public void Move(int sceneID)
    {
        PlayerPrefs.SetInt("previousScene", SceneManager.GetActiveScene().buildIndex);
        fade.SetTrigger("SceneChanged");
        StartCoroutine(PlaySoundAndLoadScene(sceneID));
    }
    IEnumerator PlaySoundAndLoadScene(int sceneID)
    {
        audioSource.clip = doorSound;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length); 
        SceneManager.LoadScene(sceneID, LoadSceneMode.Single);
    }
}
