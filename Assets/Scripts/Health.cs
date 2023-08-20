using UnityEngine;
using UnityEngine.Events;

public class Health
{
    private int _currentValue;
    private int _maxValue;
    private int _minValue;

    public Health(int maxValue = 100)
    {
        _currentValue = maxValue;
        _maxValue = maxValue;
        _minValue = 0;
    }
    
    public UnityAction<int> HealthChanged;

    public int MaxValue => _maxValue;

    public void AddHealth(int value)
    {
        _currentValue += value;
        _currentValue = Mathf.Clamp(_currentValue, _minValue, _maxValue);

        HealthChanged.Invoke(_currentValue);
    }

    public void ApplyDamage(int value)
    {
        _currentValue -= value;
        _currentValue = Mathf.Clamp(_currentValue, _minValue, _maxValue);

        HealthChanged.Invoke(_currentValue);
    }
}
