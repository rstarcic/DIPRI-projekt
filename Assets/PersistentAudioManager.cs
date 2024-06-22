using UnityEngine;

public class PersistentAudioManager : MonoBehaviour
{
    public static PersistentAudioManager instance;
    public AudioSource[] audioSources;
    private AudioClip[] previousClips;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSources = GetComponents<AudioSource>();
            previousClips = new AudioClip[audioSources.Length];
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeAmbientSound(int index, AudioClip newClip)
    {
        if (audioSources[index].clip != newClip)
        {
            previousClips[index] = audioSources[index].clip; // Save the current clip as previous
            audioSources[index].clip = newClip;
            audioSources[index].Play();
        }
    }

    public void RestorePreviousAmbientSound(int index)
    {
        if (previousClips[index] != null)
        {
            audioSources[index].clip = previousClips[index];
            audioSources[index].Play();
            previousClips[index] = null; // Clear the previous clip after restoring
        }
    }

    public static PersistentAudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("PersistentAudioManager instance not found. Make sure it is in the starting scene.");
            }
            return instance;
        }
    }
}
