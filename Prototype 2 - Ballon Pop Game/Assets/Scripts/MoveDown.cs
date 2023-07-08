using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using UnityEditor.UIElements;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float sidemovespeed = 0.5f;
    public float lowerBound = -10.0f;
    public ScoreManager scoreManager; // variable to refeence the scoremanager script 
    private Balloon Balloon;


    [SerializeField] Transform[] Points;
    [SerializeField] private float pontsmoveSpeed;
    private int pointsindex;

    /*
    [Header("follow bounds")]
    private float point_A_stop = 4f;
    private float point_B_stop = -1.1f;
    private float potin_C_stop = -4f;

    [Header("Pathways")]
    public Transform pathwayA;
    public Transform pathwayB;
    public Transform pathwayC;
    */
    // Start is called before the first frame update
    void Start()
    {
        // Refrence ScoreManger Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        transform.position = Points[pointsindex].transform.position;

        /*
        pathwayA = GameObject.FindGameObjectWithTag("Point A").GetComponent<Transform>();
        pathwayB = GameObject.FindGameObjectWithTag("Point B").GetComponent<Transform>();
        pathwayC = GameObject.FindGameObjectWithTag("Point C").GetComponent<Transform>();
        */
        
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

        if(pointsindex <= Points.Length -1)
        {   
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsindex].transform.position, sidemovespeed * Time.deltaTime);

            if(transform.position == Points[pointsindex].transform.position)
            {
                pointsindex += 1;
            }

        }
    }

}
