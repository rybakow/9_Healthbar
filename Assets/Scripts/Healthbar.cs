using System;

[Serializable]
public class Healthbar
{
    private int _healthValue;
    private int _maxHealthValue;

    public Healthbar(int maxHealthValue, int healthValue)
    {
        _maxHealthValue = maxHealthValue;
        _healthValue = healthValue;
    }
    
    public int MaxHealthValue => _maxHealthValue;
    public int HealthValue => _healthValue;
}
