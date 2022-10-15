using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Slider Slider;
    [SerializeField] private float _speedChangeValue;

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

            yield return null;
        }
    }
}