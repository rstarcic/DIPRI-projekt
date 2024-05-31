using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator playerAnim;
    public bool isActiveCharacter;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveCharacter)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Stop Walk");
                playerAnim.SetBool("Walk", false);
                playerAnim.SetBool("Back", false);
                playerAnim.SetBool("LeftStrafe", false);
                playerAnim.SetBool("RightStrafe", false);
                playerAnim.SetBool("RightTurn", false);
                playerAnim.SetBool("LeftTurn", false);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                print("Walk");
                playerAnim.SetBool("Walk", true);

            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                print("Walk Backwards");
                playerAnim.SetBool("Back", true);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                print("Strafe Left");
                playerAnim.SetBool("LeftStrafe", true);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Strafe Right");
                playerAnim.SetBool("RightStrafe", true);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                print("Turn Right");
                playerAnim.SetBool("RightTurn", true);
              
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                print("Turn Left");
                playerAnim.SetBool("LeftTurn", true);
                

            }
        }
    }
}
