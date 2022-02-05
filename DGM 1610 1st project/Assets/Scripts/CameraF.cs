using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraF : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,2,-10.63f);

    void FixedUpdate()
    {
        // Follow Players position 
        transform.position = player.transform.position + offset;
    }


}
