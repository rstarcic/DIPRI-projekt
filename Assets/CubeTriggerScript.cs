using UnityEngine;

public class CubeTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

            // Debug.Log("Car entered the trigger zone.");
            // Call the LoadNextLevel method from LevelLoader script
        LevelLoader levelLoader = FindObjectOfType<LevelLoader>();
        Debug.LogWarning("LevelLoader script not found in the scene.");
        if (levelLoader != null)
            {
                levelLoader.LoadNextLevel();
            }
            else
            {
                Debug.LogWarning("LevelLoader script not found in the scene.");
            }
        
    }
}
