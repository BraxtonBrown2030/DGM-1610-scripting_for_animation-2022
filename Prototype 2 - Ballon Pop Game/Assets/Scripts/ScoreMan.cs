using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMan : MonoBehaviour
{
    public int score; // keep trak of the score
    public TextMeshProUGUI scoreText; // text onject to br modified (edit the score text with code) 
    public int sceneToLoad;
    public MenuSctips menuScrips;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();

        
    }

    public void IncreaseScoreText( int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScoreText( int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;

        if(score <= -200)
        {
            
            Time.timeScale = 0;

        }

    }

}
