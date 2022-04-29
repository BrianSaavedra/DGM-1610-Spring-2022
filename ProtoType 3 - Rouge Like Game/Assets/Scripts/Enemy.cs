using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int curHP;

    public int maxHP;

    [Header("Enemy Attack")]

    public int damage = 1;
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player; 
    public float attackRange;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
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
    public void Die()
    {
        Destroy(gameObject);
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakenDamage(damage);
        
    }

}
