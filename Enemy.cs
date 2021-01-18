using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ChangeStatesAnim))]
public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    public HealthBar healthBar;

    public GameObject bloodSplash;
    public Transform bloodReference;
    //  private string currentState;
    EnemyGroundAi enemyGroundAi;

   
    [HideInInspector]
    public ChangeStatesAnim changeStatesAnim;

    const string HURT = "Enemy_Hurt";
    const string DIE = "Enemy_Die";

    
    void Start()
    {
        changeStatesAnim = GetComponent<ChangeStatesAnim>();
        enemyGroundAi = GetComponent<EnemyGroundAi>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
      
        }
   
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        //hurt animation
        if (currentHealth > 1)
        {
            changeStatesAnim.ChangeAnimationState(HURT);
        }
        

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
       
        enemyGroundAi.enabled = false;
        Instantiate(bloodSplash, bloodReference.position, bloodReference.rotation);
     //  changeStatesAnim.ChangeAnimationState(DIE); //die animation                   

        

        Destroy(gameObject);
    }

}
