using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridgeDoor : MonoBehaviour
{
    public Animator FridgeDoorAnimator;
    public bool isOpen;

    private void Start()
    {
        FridgeDoorAnimator = GetComponent<Animator>();
        isOpen = false;
        Debug.Log("Fridge start.");
    }
    public void ToggleDoor()
    {

        if (!isOpen)
        {
            FridgeDoorAnimator.SetBool("isOpen", true);
            Debug.Log("Fridge trying to open.");
        }
        else
        {
            FridgeDoorAnimator.SetBool("isOpen", false);
            FridgeDoorAnimator.SetBool("isClose", true);
            Debug.Log("Fridge trying to close.");
        }
        isOpen = !isOpen;
    }
}
