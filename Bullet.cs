using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    public float speed = 20f;
    public GameObject hitEffect;

    private Rigidbody2D rb2D;
    [SerializeField] private float timeToDestroy = .5f;
    [SerializeField] private float speedRotation = 100f;
    [SerializeField] private int bulletDamage = 1;    

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    } 
    void Start()
    {
        rb2D.velocity = transform.right * speed;
        Destroy(gameObject, timeToDestroy);
    }
    private void Update()
    {
        rb2D.AddTorque (speed * speedRotation , ForceMode2D.Force);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {        
       Enemy enemy = collision.GetComponent<Enemy>();
        NoPatrolStats noPatrolStats = collision.GetComponent<NoPatrolStats>();
        /* if(enemy != null)
        {
            enemy.TakeDamage(bulletDamage);
        }*/
        if (enemy != null )
        {
            enemy.TakeDamage(bulletDamage);

        }else if(noPatrolStats != null )
        {
            noPatrolStats.TakeDamage(bulletDamage);
        }
        Instantiate(hitEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
    
}
