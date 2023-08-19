using UnityEngine;
using UnityEngine.Events;

public class Healthbar
{
    private int _maxHealthValue;
    private int _minHealthValue;

    public Healthbar(int maxHealthValue)
    {
        HealthValue = maxHealthValue;
        _maxHealthValue = maxHealthValue;
        _minHealthValue = 0;
    }
    
    public UnityAction _healthChanged;

    public int HealthValue { get; private set; }
    public int MaxHealthValue => _maxHealthValue;

    public void IncreaseHealth(int value)
    {
        HealthValue += value;
        HealthValue = Mathf.Clamp(HealthValue, _minHealthValue, _maxHealthValue);
        
        _healthChanged.Invoke();
    }

    public void DecreaseHealth(int value)
    {
        HealthValue -= value;
        HealthValue = Mathf.Clamp(HealthValue, _minHealthValue, _maxHealthValue);

        _healthChanged.Invoke();
    }
}
