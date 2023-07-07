using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Player_score : ScriptableObject
{
    public float health;
    public float score;

    public void SaveScore(float other)
    {
        score = other;
    }


}
