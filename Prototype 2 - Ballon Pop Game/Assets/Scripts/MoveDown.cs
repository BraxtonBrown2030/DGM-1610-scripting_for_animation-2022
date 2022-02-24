using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10f;
    public ScoreManager ScoreManager; // variable to refeence the scoremanager script 
    private Balloon Balloon;

    // Start is called before the first frame update
    void Start()
    {
        // Refrence ScoreManger Component
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        Balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);

        // Destory Balloon after it passes lowerBound
        if(transform.position.y < lowerBound)
        {
            ScoreManager.DecreaseScoreText(Balloon.ScoreToGive);
            Destroy(gameObject);
        }
    }
}
