using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPatrolStats : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    public HealthBar healthBar;
    public Transform bloodReference;
    public GameObject bloodSplash;
    //  private string currentState;
    NoPatrolEnemy noPatrolEnemy;


    [HideInInspector]
    public ChangeStatesAnim changeStatesAnim;

    const string HURT = "Enemy_Hurt";
    const string DIE = "Enemy_Die";


    void Start()
    {
        changeStatesAnim = GetComponent<ChangeStatesAnim>();
        noPatrolEnemy = GetComponent<NoPatrolEnemy>();

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
        noPatrolEnemy.enabled = false;

        Instantiate(bloodSplash, bloodReference.position, bloodReference.rotation);
      //  changeStatesAnim.ChangeAnimationState(DIE); //die animation                   

        Destroy(gameObject);
    }
}
