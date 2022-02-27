using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // to edit text and other thing on a menu or seane
public class ScoreManager : MonoBehaviour
{
    public int score; // keep trak of the score
    public TextMeshProUGUI scoreText; // text onject to br modified (edit the score text with code) 
    

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
    }
}
