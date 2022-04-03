using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {Blue, Red, Yellow, Orange, Green, Purple};
    enum CarMake {Oldsmoblie, Chevorlet, Ford, Mazdam, Toyota, Dodge};
    enum CarModle {Alero, Curse, Tocoma, Mustang, Miata, Viper};
    enum GpuType {Nvidia, Amd, Geforece, Radion, Rtx};
    enum HiarStyle {Spikey, BullCut, CombOver, Long, Short};
    enum GamePlayed {Terreria, Fallout, MarioKart, GundamEvolution, FinalFantasy14};
    enum BestFreinds {Terry, Liz, Kyale, Connor, David};
    enum ControllerTypes {KeyBorad, Controller, Hotas, RaceingWheel, ArcadStick,};
    enum FoodTypes {HamBurger, Shake, Water, Rice, Eggs};
    enum ChipTypes {SourCream, ExtraSalt, Barbaque, Salsa, Chedder};

    void Start()
    {
        Color paint;
        paint = Color.Blue;
        Debug.Log(paint);

        CarMake make;
        CarModle modle;

        make = CarMake.Dodge;
        modle = CarModle.Viper;

        FoodTypes food;
        food = FoodTypes.Water;
        Debug.Log(food);

        ChipTypes chip;
        chip = ChipTypes.ExtraSalt;
        Debug.Log(chip);

        HiarStyle hiarCut;
        hiarCut = HiarStyle.BullCut;
        Debug.Log(hiarCut);

        Recall(CarMake.Oldsmoblie, CarModle.Alero);
        Playing(BestFreinds.Liz, GamePlayed.Terreria);
        Requirements(ControllerTypes.KeyBorad, GpuType.Amd);

        
    }
    void Recall(CarMake make, CarModle modle)
    {
        if(make == CarMake.Oldsmoblie && modle == CarModle.Alero)
        {
            Debug.Log("There is a recall on this car");
        }
        else if(make == CarMake.Ford && modle == CarModle.Mustang)
        {
            Debug.Log("there is a Recall on this car for the transmission");
        }
        else
        {
            Debug.Log("No recall for this vehicle");
        }
    }
    void Playing(BestFreinds freinds, GamePlayed games)
    {
        if(games == GamePlayed.Terreria &&  freinds == BestFreinds.Liz)
        {
            Debug.Log("Liz has invited you to play terraria with her.");
        }
        else if(games == GamePlayed.Fallout && freinds == BestFreinds.Connor)
        {
            Debug.Log("This game is singleplayer only so you can play with a friend.");
        }
        else
        {
            Debug.Log("there is no one that can play right now so playe whatever.");
        }
    }
    void Requirements(ControllerTypes conType, GpuType cardType)
    {
        if(conType == ControllerTypes.KeyBorad && cardType == GpuType.Amd)
        {
            Debug.Log("You can play this game");
        }
        else if(conType == ControllerTypes.Controller && cardType == GpuType.Nvidia)
        {
            Debug.Log("Your controller or gpu dosen note match the requirements to play this game");
        }
        else
        {
            Debug.Log("You meet all the requirements to play this game");
        }
    }
}
