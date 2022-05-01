using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider; // find slider compunter to refrence
   
   public void SetMaxHealth(int health)
   {
       // set slider value to update UT with current Hp
       slider.maxValue = health;
       slider.value = health;
   }
   public void SetHealth(int health)
   {
       // set slider to current hp
       slider.value = health;
   }
}
