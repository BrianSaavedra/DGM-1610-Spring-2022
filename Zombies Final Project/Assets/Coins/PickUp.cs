using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public enum PickUpType{Key, Coin, Gem};
    public PickUpType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickUpType.Key)
            {
                Debug.Log("You have pick up a Golden Key!");
            }
            else if(currentPickup == PickUpType.Coin)
            {
                Debug.Log("You have picked up"+ pickupAmount +"Coins");
            }
            else if(currentPickup == PickUpType.Gem)
            {
                Debug.Log("You have picked up"+ pickupAmount+"Gems");
            }
            Destroy(gameObject);
        }
    }
}
