using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_manager : MonoBehaviour
{
    public Text lifeOne;
    public Text lifeTwo;
    public Text lifeThree;
    public float playerlives;

    public GameObject lifeblockone;
    public GameObject lifelbocktwo;
    public GameObject lifeblcokthre;

    private int player;

    void Start()
    {

        Player_Movement player = gameObject.GetComponent<Player_Movement>();

    }


    void Update()
    {
        playerlives = 3;

        if(playerlives == 2)
        {

                        

        }
        else if(playerlives == 1)
        {



        }

        if(player == 0)
        {


        

        }
        

    }
}
