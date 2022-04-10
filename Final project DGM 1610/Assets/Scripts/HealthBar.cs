using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public float scaleToIncrease = 1.0f;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    void OnTakeDamage()
    {
        
    }

    void HealthBarSizeChange()
    {
        transform.localScale -+ Vector3.one * scaleToIncrease;
    }
}