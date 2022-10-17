using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Slider Slider;
    [SerializeField] private Player _player;
    [SerializeField] private float _speedChangeValue;
    [SerializeField] private TMP_Text _countDisplay;

    private Coroutine _healthChange;

    public void HealthChanger(float newHealth)
    {
        if (_healthChange != null) StopCoroutine(_healthChange);

        _healthChange = StartCoroutine(HealthChange(newHealth));
    }

    private IEnumerator HealthChange(float targeHealth)
    {
        while (Slider.value != targeHealth)
        {
            Slider.value = Mathf.MoveTowards(Slider.value, targeHealth, _speedChangeValue * Time.deltaTime);

            _countDisplay.text = Mathf.Round(Slider.value) + "/" + _player.MaxHealth;

            yield return null;
        }
    }
}