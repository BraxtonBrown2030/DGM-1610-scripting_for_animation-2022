using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ballonpathways : ScriptableObject
{
    
    public GameObject pathwayA;
    public GameObject pathwayB;
    public GameObject pathwayC;

    void Start()
    {

        pathwayA = GameObject.FindGameObjectWithTag("Point A");
        pathwayB = GameObject.FindGameObjectWithTag("Point B");
        pathwayC = GameObject.FindGameObjectWithTag("Point C");


    }

}
