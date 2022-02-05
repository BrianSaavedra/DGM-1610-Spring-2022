using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 100.0f;
    private float turnSpeed = 50.0f;
    private float hinput;
    private float finput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hinput = Input.GetAxis("Horizontal");
        finput = Input.GetAxis("Vertical");

        // Makes the player move 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * finput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hinput);
    }
}   
