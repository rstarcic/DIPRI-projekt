using UnityEngine;

public class ChangeAmbientSoundScript : MonoBehaviour
{
    public int audioSourceIndex;
    public AudioClip newAmbientSound;

    void Start()
    {
        PersistentAudioManager.Instance.ChangeAmbientSound(audioSourceIndex, newAmbientSound);
    }
}
