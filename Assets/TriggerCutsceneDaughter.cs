using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutsceneDaughter : MonoBehaviour
{
    [SerializeField] private GameObject _cutscene;
    [SerializeField] private AudioSource audioSource;

    private bool cutsceneTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !cutsceneTriggered)
        {
            // Check if audio source is playing and stop it if necessary
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            // Activate the cutscene GameObject
            _cutscene.SetActive(true);

            // Set the flag to true to disable future triggering
            cutsceneTriggered = true;
        }
    }
}
