using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GeneralInput : MonoBehaviour, Control.IDialogActionActions
{
    private Control control;
   

    private void Awake()
    {
     
        control = new Control();
        control.DialogAction.SetCallbacks(this);
       

        // doorBehavior = FindObjectOfType<DoorBehavior>().GetComponent<DoorBehavior>();
    }
    private void OnEnable()
    {
        control.DialogAction.Enable();
    }
    private void OnDisable()
    {
        control.DialogAction.Disable();
    }

    public void OnConfirm(InputAction.CallbackContext context)
    {
       
    }

    public void OnCallDialogue(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
                      

        }

    }

    public void OnCancel(InputAction.CallbackContext context)
    {
        if (context.performed)
        {           
          FindObjectOfType<PlayerController>().enabled = true; // habilita o controle do player  apos fechar janela de dialogo 
                 

        }
    }
}
