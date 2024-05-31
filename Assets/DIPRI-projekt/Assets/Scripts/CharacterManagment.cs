using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public List<PlayerControl> characters;
    private int currentIndex;

    private void Start()
    {
        if (characters.Count > 0)
        {
            SetActiveCharacter(0);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActiveCharacter(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActiveCharacter(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActiveCharacter(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetActiveCharacter(3);
        }
    }

    private void SetActiveCharacter(int index)
    {
        if (index >= 0 && index < characters.Count)
        {
            if (currentIndex >= 0 && currentIndex < characters.Count)
            {
                characters[currentIndex].isActiveCharacter = false;
            }

            currentIndex = index;
            characters[currentIndex].isActiveCharacter = true;
        }
    }
}
