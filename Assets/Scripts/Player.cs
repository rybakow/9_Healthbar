using System;
using Interfaces;
using UnityEngine;

public class Player : MonoBehaviour, IHealthAbility
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _minHealth;
    
    private int _health;
    
    private void Awake()
    {
        _health = _maxHealth;
    }
    
    public void Heal()
    {
        if (_health < _maxHealth)
            _health += 1;
    }
    
    public void Damage()
    {
        if (_health > _minHealth)
            _health -= 1;
    }

    public int GetHealth()
    {
        return _health;
    }
}
