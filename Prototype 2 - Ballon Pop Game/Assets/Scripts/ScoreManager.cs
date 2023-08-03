using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // to edit text and other thing on a menu or seane
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep trak of the score
    public TextMeshProUGUI scoreText; // text onject to br modified (edit the score text with code) 
    public int sceneToLoad;
    public MenuSctips menuScrips;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();

        menuScrips = GameObject.FindGameObjectWithTag("Death Menu").GetComponent<MenuSctips>();
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
            
            menuScrips.deathcanvas.enabled = true;
            Time.timeScale = 0;

        }

    }


}
