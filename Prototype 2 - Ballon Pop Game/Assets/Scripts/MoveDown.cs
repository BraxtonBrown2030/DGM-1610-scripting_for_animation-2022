using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10.0f;
    public ScoreManager scoreManager; // variable to refeence the scoremanager script 
    private Balloon Balloon;

    [Header("follow bounds")]
    private float point_A_stop;
    private float point_B_stop;
    private float potin_C_stop;

    [Header("Pathways")]
    public GameObject pathwayA;
    public GameObject pathwayB;
    public GameObject pathwayC;

    // Start is called before the first frame update
    void Start()
    {
        // Refrence ScoreManger Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        pathwayA = GameObject.FindGameObjectWithTag("Point A");
        pathwayB = GameObject.FindGameObjectWithTag("Point B");
        pathwayC = GameObject.FindGameObjectWithTag("Point C");

        
        Balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);

        

        // Destory Balloon after it passes lowerBound
        if(transform.position.y < lowerBound)
        {
            scoreManager.DecreaseScoreText(Balloon.ScoreToGive);
            Destroy(gameObject);
        }
    }
}
