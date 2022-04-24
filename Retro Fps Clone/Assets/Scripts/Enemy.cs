using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform startPoint;
    public float maxX;
    public float minX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;

        startPoint.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, startPoint.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, startPoint.position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                startPoint.position = new Vector3(Random.Range(minX,maxX), Random.Range(minY,maxY));
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
