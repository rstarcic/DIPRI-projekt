using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Toggle()
    {
        if (isOpen)
        {
            animator.SetTrigger("isClose");
        }
        else
        {
            animator.SetTrigger("isOpen");
        }

        isOpen = !isOpen;
    }

}
