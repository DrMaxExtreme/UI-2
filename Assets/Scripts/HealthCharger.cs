using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCharger : MonoBehaviour
{
    [SerializeField] float HealthChange;
    [SerializeField] Player Player;

    public void OnButtonClick()
    {
        Player.HealthChange(HealthChange);
    }
}
