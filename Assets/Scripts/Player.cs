using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.HealthChanger(_maxHealth, _maxHealth);
    }

    public void HealthChange(float health)
    {
            if (_currentHealth + health >= _maxHealth)
                _currentHealth = _maxHealth;
            else if (_currentHealth + health <= 0)
                _currentHealth = 0;
            else
                _currentHealth += health;

        _healthBar.HealthChanger(_currentHealth, _maxHealth);
    }
}
