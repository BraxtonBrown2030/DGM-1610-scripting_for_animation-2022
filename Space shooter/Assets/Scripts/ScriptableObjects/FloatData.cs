using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float amount = 0f;

    public void UpdateAmount(float other)
    {
        amount += other;
    }
}
