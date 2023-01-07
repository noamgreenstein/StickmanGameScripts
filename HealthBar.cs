using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//allows creation of variable to store slider;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void setHealth(int health){
      slider.value = health;
    }
    public void setMaxHealth(int health){
      slider.maxValue = health;
      slider.value = health;
    }
}
