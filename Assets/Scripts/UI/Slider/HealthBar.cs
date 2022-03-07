using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Color color;
    public Image fill;

    public void SetMaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        //fill.color = gradient.Evaluate(1f);
        fill.color = color;
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        //fill.color = gradient.Evaluate(slider.normalizedValue);
        fill.color = color;
        if(slider.value == 0)
        {
            Destroy(gameObject);
        }
    }
}
