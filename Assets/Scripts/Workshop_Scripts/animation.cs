using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animation : MonoBehaviour
{
    public InputActionAsset PlayerAction;
    public Animator Animator;

    void Update()
    {
        if (PlayerAction.FindAction("Movement").IsPressed())
        { 
            Animator.SetBool("move", true);
        }
        else
            Animator.SetBool("move", false);
    } 
}

   
