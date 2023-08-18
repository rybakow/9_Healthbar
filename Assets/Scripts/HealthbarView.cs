using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarView : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollbar;

    private float normalizedValue;

    public void Render(Healthbar healthbar)
    {
        normalizedValue = (float)healthbar.HealthValue / (float)healthbar.MaxHealthValue;
    }

    private void Update()
    {
        if (_scrollbar.value != normalizedValue)
            _scrollbar.value = Mathf.MoveTowards(_scrollbar.value, normalizedValue, Time.deltaTime);
    }
}
