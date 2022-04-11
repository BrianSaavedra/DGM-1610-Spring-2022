using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
     public string npcConv;

     //public int socialClass = 1; 

     void Start()
    {
       
        switch(npcConv)
         
        
        {
            
            case "Hello":
             print("Hello good citizen! May the blessing of zandar be upon you!");
             break;
            case "GoodBye":
             print("Goodbye! Safe travles to you and your party!");
             break;
            case "We are being attacked":
             print("You run away in shame, you coward!");
             break;

             
             

        }
        

        /*
        switch(socialClass)
        {
            case 5:
            Debug.Log("Hello you're Magesty!");
            break;
            case 4:
            Debug.Log("Hello Young Princess!");
            break;
            case 3:
            Debug.Log("Good evening Duke Urtho!");
            break;
            case 2:
            Debug.Log("Hello, Mayor!");
            break;
            case 1:
            Debug.Log("May I purchase some of your fine cheeses!?");
            break;
            case 0:
            Debug.Log("Get away from me you riff raff!");
            break;
            default:
            Debug.Log("I do not talk with strangers!");
            

        }
        */
    
    }
}
