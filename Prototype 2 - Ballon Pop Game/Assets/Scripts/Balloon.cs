using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int ScoreToGive = 100; // points givin when a balloon is poped
    public int ClickToPop = 3; // how many clicks before balloon pops
    public float scaleToIncrease = 0.10f; // the amount of scale the balloon grows when you click it ( 0.1 is 10%)

    public ScoreManager ScoreManager; // variable to refeence the scoremanager script 
    void Start() // at start this will run
    {
        
    }

    void Update() // this will update every frame
    {
    
    }

    void OnMouseDown() // this event will trigger on a mouse press
    {
        ClickToPop -= 1; // this will reduse the number by one per click(reduse clicks by one)

        transform.localScale += Vector3.one * scaleToIncrease; // this will times(*)  the balloon size by the number after vector3 (Increase)

        if(ClickToPop == 0)
        {
            ScoreManager.IncreaseScoreText(ScoreToGive);
            Destroy(gameObject);
        }
    }
}
