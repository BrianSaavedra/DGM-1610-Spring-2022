using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 50.0f;
    public float hinput;
    public float finput;

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
        transform.Translate(Vector3.forward * Time.deltaTime * finput);
        transform.Translate(Vector3.right *Time.deltaTime * hinput);
    }
}
