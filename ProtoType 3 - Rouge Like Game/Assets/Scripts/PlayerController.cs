using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int curHP;
    public int maxHP;

    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 direction;

    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.X))
        {
            if(Time.time - lastAttackTime >= attackRate)
                  Attack();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;

    }

    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakenDamage(damage);
        }
    }
    public void TakenDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has bit the dust!");
    }
}   
