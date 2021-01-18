using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStatesAnim : MonoBehaviour
{
    private string currentState;
    private Animator animator;



    //const string SHOOT = "Enemy_Shoot";
    //const string RUN = "Enemy_Run";
    //const string IDLE = "Enemy_Idle";
    //const string HURT = "Enemu_Hurt";
    //const string DIE = "Enemy_Die";
    //const string WALK = "Enemy_Walk";
    //const string INGUARD = "Enemy_InGuard";

    private void Awake()
    {
        
        animator = GetComponentInChildren<Animator>();        

    }
    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
