using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyGroundAi : MonoBehaviour
{
   
    public Transform attackPoint;
    public Transform spawnBullet;
    public float attackRange = 0.5f;
    // public LayerMask damageLayer;
    public int attackDamage = 40;
    public Vector2 attackSize = new Vector2(15f, 1f);

    /*attack*/

    #region public variable
    public Transform rayCast;
    public LayerMask rayCastMask;
    public float rayCastLength;
    public float attackDistance; //  minimoum attack distance
    public float moveSpeed;
    public float timer; // time between attacks
    public Transform leftLimit;
    public Transform rightLimit;

    public GameObject bullet;
    #endregion

    #region Private variables
    private RaycastHit2D hit;
    private Animator animator;
    private Transform target;
    private float distance;
    private bool attackMode;
    private bool inRange;
    private bool cooling;
    private float inTimer;
 
    [HideInInspector]
    public ChangeStatesAnim changeStatesAnim;
    #endregion


    const string SHOOT = "Enemy_Shoot";
    const string RUN = "Enemy_Run";
    const string IDLE = "Enemy_Idle";
    const string HURT = "Enemu_Hurt";
    const string DIE = "Enemy_Die";
    const string WALK = "Enemy_Walk";
    const string INGUARD = "Enemy_InGuard";
    private void Awake()
    {
        SelectTarget();
        inTimer = timer;
        animator = GetComponentInChildren<Animator>();
        changeStatesAnim = GetComponent<ChangeStatesAnim>();    

    }
   
    void FixedUpdate()
    {
        if (isActiveAndEnabled == false) return;

        if (!attackMode)
        {
            Move();
        }

        

        if (!InsideOfLimit() && !inRange)
        {
            SelectTarget();
        }
       
        hit = Physics2D.Raycast(rayCast.position, transform.right, rayCastLength, rayCastMask);
        RayCastDebugger();
   



        if (hit.collider != null)
        {
            EnemyLogic();
            target = hit.transform;
            inRange = true;
            Flip();
        }
        else if (hit.collider == null)
        {
            inRange = false;
        }

        if (inRange == false)
        {
           
            StopAttack();
        }
           

    }

    private void EnemyLogic()
    {
        distance = Vector2.Distance(transform.position, target.position);

        if (distance > attackDistance)
        {
           
            StopAttack();

        }
        else if (attackDistance >= distance && !cooling)
        {
            Attack();
            TriggerCooling();

        }

        if (cooling)
        {
            CoolDown();
            changeStatesAnim.ChangeAnimationState(INGUARD);
           
        }
    }

    private void StopAttack()
    {
        cooling = false;
        attackMode = false;      
    }

    private void Attack()
    {
        timer = inTimer;
        attackMode = true;

        changeStatesAnim.ChangeAnimationState(SHOOT);

    }
    public void SpawnBullet()
    {
        Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
    }
    public void ApplyDamage()
    {
        
        Collider2D[] hitEnemies = Physics2D.OverlapBoxAll(attackPoint.position, attackSize,3f, rayCastMask);

        foreach (Collider2D enemies in hitEnemies)
        {
            enemies.GetComponent<PlayerStats>().TakeDamage(attackDamage);
            
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireCube(attackPoint.position, attackSize);
    }

    void Move()
    {
        if (isActiveAndEnabled == false) return;
        changeStatesAnim.ChangeAnimationState(RUN);

       
            Vector2 targetPosition = new Vector2(target.position.x, target.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
      
    }
    void CoolDown()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && cooling && attackMode)
        {
            cooling = false;
            timer = inTimer;
        }
    }
    private void RayCastDebugger()
    {
        if (distance > attackDistance)
        {
            Debug.DrawRay(rayCast.position, transform.right * rayCastLength, Color.red);
        }
        else if (attackDistance > distance)
        {
            Debug.DrawRay(rayCast.position, transform.right * rayCastLength, Color.green);
        }
    }

   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target = collision.transform;
            inRange = true;
            Flip();
        }
    }
    public void TriggerCooling()
    {
        cooling = true;
    }

    private void Flip()
    {
        Vector3 rotation = transform.eulerAngles;
        if (transform.position.x > target.position.x)
        {
            rotation.y = 180f;
        }
        else
        {
            rotation.y = 0f;
        }
        transform.eulerAngles = rotation;
    }
    private bool InsideOfLimit()
    {
        return transform.position.x > leftLimit.position.x && transform.position.x < rightLimit.position.x;
    }
    private void SelectTarget()
    {

        float distanceLeft = Vector2.Distance(transform.position, leftLimit.position);
        float distanceRight = Vector2.Distance(transform.position, rightLimit.position);

        if (distanceLeft > distanceRight)
        {
            target = leftLimit;
        }
        else
        {
            target = rightLimit;

        }
       
        Flip();
    }
}
