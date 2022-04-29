using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoints : MonoBehaviour
{
     public int ScoreToGive = 100; 
    
    public int clickToKill = 6; 

    public float scaleToIncrease = 0.10f; 

    public ScoreManager scoreManager; 

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        
    }


    void OnMouseDown()
    {
        
      
        clickToKill -= 1;

        

        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToKill == 0)
        {
            scoreManager.IncreaseScoreText(ScoreToGive);
            Destroy(gameObject);

        }
    } 

}
