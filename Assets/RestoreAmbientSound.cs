using UnityEngine;

public class RestoreAmbientSoundScript : MonoBehaviour
{
    public int audioSourceIndex;

    void Start()
    {
        PersistentAudioManager.Instance.RestorePreviousAmbientSound(audioSourceIndex);
    }
}
