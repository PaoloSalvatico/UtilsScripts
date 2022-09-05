using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressiveHealthBar : MonoBehaviour
{
    // First upfront slider
    [SerializeField] private Slider _greenSlider;
    // Second slider behind first one
    [SerializeField] private Slider _whiteSlider;

    /// <summary>
    /// Set player Max healt
    /// </summary>
    /// <param name="maxHealth"> max health</param>
    public void SetMaxHealth(int maxHealth)
    {
        _greenSlider.maxValue = maxHealth;
        _greenSlider.value = maxHealth;
        _whiteSlider.maxValue = maxHealth;
        _whiteSlider.value = maxHealth;
    }

    /// <summary>
    /// Set player max shield
    /// </summary>
    /// <param name="maxShield">max shield</param>
    public void SetMaxShield(int maxShield)
    {
        _greenSlider.maxValue = 100;
        _greenSlider.value = 0;
        _whiteSlider.maxValue = 100;
        _whiteSlider.value = 0;
    }

    /// <summary>
    /// Set player current health after a damage, both health and shield
    /// </summary>
    /// <param name="currentHealth">new int health or shield</param>
    /// <param name="previous">old health or shield</param>
    public void SetCurrentHealth(int currentHealth, int previous)
    {
        _greenSlider.value = currentHealth;
        StartCoroutine(ActiveWhiteSlider(currentHealth, previous));
    }

    public void SetTeammateHealth(int currentHealth)
    {
        _greenSlider.value = currentHealth;
    }
    public void SetTeammateShield(int currentShield)
    {
        _greenSlider.value = currentShield;
    }

    /// <summary>
    /// Move the white bar under the health or shield bar to the same value after time
    /// </summary>
    /// <param name="currentHealth">new health or shield bar value</param>
    /// <param name="previousHealth">old health or shield bar value</param>
    /// <returns></returns>
    public IEnumerator ActiveWhiteSlider(int currentHealth, float previousHealth)
    {
        yield return new WaitForSeconds(1f);
        while (previousHealth > (currentHealth))
        {
            _whiteSlider.value = previousHealth;
            previousHealth -= Time.deltaTime * 11;
            yield return new WaitForEndOfFrame();
        }
        _whiteSlider.value = currentHealth;
    }
}
