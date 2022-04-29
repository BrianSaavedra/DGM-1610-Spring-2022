using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    private Vector3 direction;

    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;

    public static PlayerController instance;
   
    
    private Vector3 moveInput;
    private Vector2 mouseInput;

    public float mouseSensitivity = 1.0f;

    public GameObject bulletImpact;
    public int currentAmmo;
    public Camera viewCam;



    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        curHP = maxHP;
        healthBar.SetHealth(maxHP);

        Cursor.visible = false;
        Cursor. lockState = CursorLockMode.Locked;
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


        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical")); //Getting Inputs
        Vector3 moveH = transform.right * moveInput.x;
        Vector3 moveV = transform.forward * moveInput.z;
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);
        
        if(Input.GetMouseButtonDown(0))
        {
            if(currentAmmo > 0)
        {
            Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("I'm lookin at " + hit.transform.name);
                Instantiate(bulletImpact, hit.point, transform.rotation);
            }
            else 
            {
                Debug.Log("I'm not looking at anything!");
            }

            currentAmmo --;
        }

        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector3 vel = new Vector3(movement.x,movement.y);

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
        healthBar.SetHealth(curHP);

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
