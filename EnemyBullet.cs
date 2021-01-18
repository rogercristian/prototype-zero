using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speed = 20f;

    [SerializeField] private float timeToDestroy = .5f;
   
    [SerializeField] private int bulletDamage = 1;

    public GameObject hitEffect;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2D.velocity = transform.right * speed;
        Destroy(gameObject, timeToDestroy);
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {

        PlayerStats enemy = collision.GetComponent<PlayerStats>();

        if (enemy != null)
        {
            enemy.TakeDamage(bulletDamage);
        }

        Instantiate(hitEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
  
}
