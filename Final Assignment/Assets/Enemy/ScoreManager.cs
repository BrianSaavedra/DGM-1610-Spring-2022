using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
     public int score; // Keep track of the score

    public TextMesh scoreText; // Textobject to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }


    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();

    }

    public void DecreaseScoreText(int amount)
    {
        score-= amount;
        UpdateScoreText();
    }
    


    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
