using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    // public string lightColor;
    //public string weather;
    public string hairColor;
    public int age;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(lightColor == "Red")
        {
            Debug.Log("The light is "+ lightColor + " STOP ");
        }
        else if(lightColor == "Yellow")
        {
             Debug.Log("The light is "+ lightColor + "Start to slow down");
        }
        else if(lightColor == "Green")
        {
             Debug.Log("The light is "+ lightColor + "Go");
        }
        else
        {
            Debug.Log("There isn't a stop light of that color");
        }
        */

        /*
        if(weather == "Rain" || weather == "Snow")
        {
            Debug.Log("The weather is bad, you should wear a coat!");
        }
        else if(weather == "Sunny" || weather == "Partly Cloudy")
        {
            Debug.Log("You do not need a coat");
        }
        */
        if(hairColor == "Red" && age == 6)
        {
            Debug.Log("You can ride the FireRide!");
        }
        else if(hairColor == "Blonde" && age == 100)
        {
            Debug.Log("You are old enough to ride FireRide!");
        }
       

    }
}
