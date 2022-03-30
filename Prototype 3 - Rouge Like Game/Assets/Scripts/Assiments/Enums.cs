using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {Blue, Red, Yellow, orange, Green, Purple};
    enum CarMake {Oldsmoblie, Chevorlet, ford, mazdam, toyota, Dodge};
    enum CarModle {Alero, curse, Tocoma, Mustang, Miata, Viper};
    // Start is called before the first frame update
    void Start()
    {
        Color paint;
        paint = Color.Blue;
        Debug.Log(paint);

        CarMake make;
        CarModle modle;


        make = CarMake.Dodge;
        modle = CarModle.Viper;
        // print ("Car Manufacture: " make " modle: " + modle);

        Recall(CarMake.Oldsmoblie, CarModle.Alero);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Recall(CarMake make, CarModle modle)
    {
        if(make == CarMake.Oldsmoblie && modle == CarModle.Alero)
        {
            Debug.Log("There is a recall on this car");
        }
        else if(make == CarMake.ford && modle == CarModle.Mustang)
        {
            Debug.Log("there is a Recall on this car for the transmission");
        }
        else
        {
            Debug.Log("No recall for this vehicle");
        }
    }
}
