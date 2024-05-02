using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimationBehaviour : MonoBehaviour
{
    public Animator DrawerAnimator;
    public bool isOpen;

    private void Start()
    {
        DrawerAnimator = GetComponent<Animator>();
        isOpen = false;
    }
    public void ToggleDrawer()
    {
 
        if (!isOpen)
        {
            DrawerAnimator.SetTrigger("Open");
            isOpen = true;
        }
        else
        {
            DrawerAnimator.SetTrigger("Close");
            isOpen = false;
        }
        isOpen = !isOpen;
    }
}