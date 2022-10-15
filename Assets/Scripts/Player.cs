using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] HealthBar HealthBar;
    [SerializeField] float maxHealth = 100;
    [SerializeField] float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        HealthBar.HealthChange(maxHealth);
    }

    public void HealthChange(float health)
    {
            if (currentHealth + health >= maxHealth)
                currentHealth = maxHealth;
            else if (currentHealth + health <= 0)
                currentHealth = 0;
            else
                currentHealth += health;

        HealthBar.HealthChange(currentHealth);
    }
}
