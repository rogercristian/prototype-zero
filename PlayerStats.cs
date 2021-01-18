using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Image playerHitEffect;
    public HealthBar healthBar;
    const string DIE = "Die";
    const string HURT = "Hurt";
    /**/
   

    /*---------------------------------*/
    //public Transform rayCast;
    //public LayerMask rayCastMask;
    //public float rayCastLength;

    private PlayerController pc;
    private Player2Comtroller player2Comtroller;


    GameObject hitEffect;
    GameObject healthObject;
   

    private string currentState;
    private Animator animator;
   [SerializeField] private float resetHitTime = .2f;

    //  public float attackDistance; //  minimoum attack distance

    //private RaycastHit2D hit;       
    //private bool inRange;   
    //private float inTimer;

    private void Awake()
    {
        healthObject = GameObject.Find("HUD_PLayer");
        healthBar = healthObject.GetComponentInChildren<HealthBar>();

    }
    // Start is called before the first frame update
    void Start()
    {        
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        pc = GetComponent<PlayerController>();
        if (pc == null)
        {
            player2Comtroller = GetComponent<Player2Comtroller>();

        }

        animator = GetComponent<Animator>();

        
        hitEffect = GameObject.Find("PlayerHitEffect");       
        playerHitEffect = hitEffect.GetComponent<Image>();
        playerHitEffect.gameObject.SetActive(false);
       


    }


    //public void Attack()
    //{

    //    hit = Physics2D.Raycast(rayCast.position, transform.right, rayCastLength, rayCastMask);
    //    Debug.DrawRay(rayCast.position, transform.right * rayCastLength, Color.red);
    //    if (hit.collider == null) return;

    //    Enemy enemy = hit.collider.GetComponent<Enemy>();
    //    EnemyGroundAi enemyGroundAi = hit.collider.GetComponent<EnemyGroundAi>();

    //    if (enemy != null)
    //    {
    //        enemy.TakeDamage(attackDamage);

    //    }

    //}
    public IEnumerator ResetHitEffect()
    {
        yield return new WaitForSeconds(resetHitTime);
       
       playerHitEffect.gameObject.SetActive(false);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        // ChangeAnimationState(HURT);

       
        playerHitEffect.gameObject.SetActive(true);
        StartCoroutine(ResetHitEffect());
        if (currentHealth <=0)
        {
            Die();
        }
    }
    public void Die()
    {
        // animation die
      //  Debug.Log("Player Morreu");
      if(pc != null)
        {
            pc.enabled = false;

        }else
        {
            player2Comtroller.enabled = false;
        }

        ChangeAnimationState(DIE);
       
        //this.enabled = false;
       Destroy(gameObject, 2f);
        //call game over
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
