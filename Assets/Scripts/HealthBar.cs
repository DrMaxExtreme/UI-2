using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private float _speedChangeValue;
    [SerializeField] private TMP_Text _countDisplay;
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fill;

    private Coroutine _healthChange;

    public void HealthChanger(float newHealth, float maxHealth)
    {
        if (_healthChange != null) StopCoroutine(_healthChange);

        _healthChange = StartCoroutine(HealthChange(newHealth, maxHealth));
    }

    private IEnumerator HealthChange(float targeHealth, float maxHealth)
    {
        while (_slider.value != targeHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targeHealth, _speedChangeValue * Time.deltaTime);

            _countDisplay.text = Mathf.Round(_slider.value) + "/" + maxHealth;

            _fill.color = _gradient.Evaluate(_slider.normalizedValue);

            yield return null;
        }
    }
}