using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCutsceneTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _cutscene;
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        Debug.Log("Player entered");
        {

             StartCoroutine(ActivateCutsceneWithDelay(5.0f));
        }
    }
    private IEnumerator ActivateCutsceneWithDelay(float delay)
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);
        if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        // Activate the cutscene GameObject after the delay
        _cutscene.SetActive(true);
    }
}
