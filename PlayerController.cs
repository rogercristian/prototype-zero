using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, Control.IPlayerActions
{
    private Control control; // variavel que guarda o asset do novo inputsystem 
    public float speed = 300f;
    public float runMultiply = 2f;

    private float runSpeed;
    private float setMovementHorizontal;  // define o movimento horizontal
    private float setMovementVertical;   // define movimento vertical
    private Rigidbody2D rg2D;
    private bool isFlipíng = false;
    private bool isShoot = false;
    private bool isRunning = false;
    private bool isWalking = false;

    private Animator animator;
    private string currentState;
    public Transform shootPoint;
    public GameObject bullet;


    public float attackRate = 2f;
    float nextAttackTime = 0f;


    /**/

    const string IDLE = "Idle";
    const string WALK = "Walk";
    const string RUN = "Run";
    const string SHOOT = "Shoot";
    const string RUNSHOOT = "RunShoot";
    const string HURT = "Hurt";

    
    private void Awake()
    {
        control = new Control();   // seta um novo Control
        control.Player.SetCallbacks(this); // atribui o esquema do input system

        rg2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        runSpeed = speed;
    }
    private void OnEnable()
    {
        control.Player.Enable();
    }

    private void OnDisable()
    {
        control.Player.Disable();
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }

     void Update()
    {
        if (setMovementHorizontal != 0 || setMovementVertical != 0) 
        {
            isWalking = true;
        }
        else {
            isWalking = false;           
        }
        if (!isWalking && !isShoot)
        {
            ChangeAnimationState(IDLE);

        }
        /**/
        if (isWalking && !isRunning &&!isShoot)
        {
            ChangeAnimationState(WALK);

        }

        if (isRunning && isWalking && !isShoot)
            {
                ChangeAnimationState(RUN);
            }              

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // guarda os valores do input do DPAD/Setas/WASD
        rg2D.velocity = new Vector2( setMovementHorizontal * speed * Time.deltaTime, setMovementVertical * speed * Time.deltaTime);

        if (isShoot && currentState != HURT)
        {
            Shoot();
        }

        Flip();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        setMovementHorizontal = context.ReadValue<float>();
       // ChangeAnimationState(WALK);
    }

   public void OnVertical(InputAction.CallbackContext context)
    {

        setMovementVertical = context.ReadValue<float>();
       // ChangeAnimationState(WALK);
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            isShoot = true;
            
        }
        if (context.canceled)
        {
            isShoot = false;          

        }
    }
    private void SpawnBullet()
    {
        if (Time.time >= nextAttackTime)
        {
            //  Instantiate(bullet, shootPoint.position, shootPoint.rotation);


            Instantiate(bullet, shootPoint.position, shootPoint.rotation);

            nextAttackTime = Time.time + 1f / attackRate;
        }
    }
    private void Shoot()
    {

        //  Instantiate(bullet, shootPoint.position, shootPoint.rotation);

        if (!isWalking && isShoot)
        {
            ChangeAnimationState(SHOOT);

        }
        if (isShoot && isWalking || isShoot && isWalking && isRunning)
        {
            ChangeAnimationState(RUNSHOOT);

        }

            SpawnBullet();

    }
    void Flip()
    {
        bool flip = isFlipíng;
        Vector3 rotation = transform.eulerAngles;

        if(setMovementHorizontal < 0 && !flip)
        {
            rotation.y = 180f;
            isFlipíng = true;

        } else if(setMovementHorizontal > 0 && flip)
        {
            rotation.y = 0f;
            isFlipíng = false;
        }
        transform.eulerAngles = rotation;
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isRunning = true;
            speed *=  runMultiply;
        }
        if (context.canceled)
        {
            isRunning = false;
            speed = runSpeed;
        }
    }
   
}
