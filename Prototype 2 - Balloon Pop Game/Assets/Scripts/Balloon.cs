using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int ScoreToGive = 100; //Score for Balloon pop. 
    
    public int clickToPop = 3; //Clicks for Balloon pop.

    public float scaleToIncrease = 0.10f; //Scale Increase each time the balloon Is clicked. 

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Reduce clicks by 
      
        clickToPop -= 1;

        //Increase

        transform.localScale += Vector3.one * scaleToIncrease ;

        if(clickToPop == 0)
        {
            Destroy(gameObject);

        }
    } 

}

