using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class scriptiblobjects : ScriptableObject

{

    public float amount;
    public int moeney;

    void Start()
    {
        
    }

    public void UpdateAmount(float other)
    {

        amount += other; 

    }

}
