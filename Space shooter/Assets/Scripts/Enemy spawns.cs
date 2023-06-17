using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawns : MonoBehaviour
{
    [Header("cordanints")]
    public float x_point;
    public float y_point;

    [Header("Enemy type")]
    public int number_of_enemeys;
    public int type_of_enemies;

    [Header("Range and detection")]
    public float range;


    public Player_Movement player;
    public int speed;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player_Movement>();

        
    }

     void Update()
    {
    


    }

    void ActivateRage()
    {

    }

    void Spawn()
    {

    }
}
