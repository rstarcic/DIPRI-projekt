using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundScript : MonoBehaviour
{
    public AudioSource audioSource;
    private bool hasPlayed = false;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("PLayer enter box collider");
        if (other.CompareTag("Player") && !hasPlayed)
        {
            Debug.Log("Audio should be heared");
            audioSource.Play();
            hasPlayed = true;
        }
    }
}
