using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPatrolEnemy : MonoBehaviour
{

    public LayerMask targetMask;
    public Transform raycast;
    public float raycastLength;
    public float distanceAttack;
    public float moveSpeed;
    public float timer;
    public GameObject bullet;
    public Transform shootPoint;

    private  RaycastHit2D hit;
    private Transform target;
    GameObject player;
   // private PlayerController target;
    private float distance;
    private bool attackMode;
    private bool inRange;
    private bool coolling;
    private float inTimer;
    private ChangeStatesAnim changeStatesAnim;

    const string ENEMY_SHOOT = "Enemy_Shoot";
  //  const string ENEMY_IDLE = "Enemy_Idle";
    const string ENEMY_RUN = "Enemy_Run";
    const string ENEMY_INGUARD = "Enemy_InGuard";

    private void Awake()
    {
        inTimer= timer;
        changeStatesAnim = GetComponent<ChangeStatesAnim>();
      //  player = GameObject.FindGameObjectWithTag("Player");
      //  target = player.transform;
         target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (!attackMode) Move();

        hit = Physics2D.Raycast(raycast.position, transform.right, raycastLength, targetMask);
        RaycastDebugger();

        // player detected

        if (hit.collider != null)
        {
           inRange = true;
            EnemyLogic();

            target = hit.transform;           

            Flip();

        } else if(hit.collider == null)
        {
            inRange = false;
        }
        if (inRange == false)
        {
           // changeStatesAnim.ChangeAnimationState(ENEMY_IDLE);
            StopAttack();
        }
    }
   
    private void EnemyLogic()
    {
        distance = Vector2.Distance(transform.position, target.position);

        if (distance > distanceAttack)
        {
            
            StopAttack();
           // Move();
    
        }
        else if (distanceAttack >= distance && !coolling)
        {
            Attack();
        }
        if (coolling)
        {
            CoollingDown();
        }
    }

    private void Attack()
    {
        timer = inTimer;
        attackMode = true;
        changeStatesAnim.ChangeAnimationState(ENEMY_SHOOT);
    }

    private void Move()
    {
        changeStatesAnim.ChangeAnimationState(ENEMY_RUN);

        Vector2 targetPosition = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        Flip();
    }

    private void StopAttack()
    {
        coolling = false;
        attackMode = false;

       // changeStatesAnim.ChangeAnimationState(ENEMY_IDLE);
    }

    public void CoollingDown()
    {
        timer -= Time.deltaTime;
        changeStatesAnim.ChangeAnimationState(ENEMY_INGUARD);

        if (timer<=0 && coolling && attackMode)
        {
            coolling = false;
            timer = inTimer;
        }
    }
    public void TriggerCoolling()
    {
        coolling = true;
    }
   public void Shooting()
    {
        Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        
    }

    private void RaycastDebugger()
    {
        if(distance > distanceAttack)
        {
            Debug.DrawRay(raycast.position, transform.right * raycastLength, Color.red);
        }
       else if (distance < distanceAttack)
        {
            Debug.DrawRay(raycast.position, transform.right * raycastLength, Color.green);
        }
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
}
