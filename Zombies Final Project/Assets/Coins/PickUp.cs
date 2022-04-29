using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   public enum PickUpType{Coin};
    public PickUpType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;

    public ScoreManager scoreManager; 
    public int ScoreToGive = 1000; 

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickUpType.Coin)
            {
                Debug.Log("You have pick up a Boss Coin");
                scoreManager.IncreaseScoreText(ScoreToGive);

            }
            
        }
    }

    
}
