using Interfaces;
using UnityEngine;

[RequireComponent(typeof(HealthbarSetter))]
public class Player : MonoBehaviour, IHealthAbility
{
    [SerializeField] private HealthbarSetter _healthbarSetter;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _minHealth;
    
    private int _health;

    private void Awake()
    {
        _health = _maxHealth;
        _healthbarSetter._healthChanged.Invoke();
    }
    
    public void Heal(int healPoints)
    {
        if (_health < _maxHealth)
            _health += healPoints;
        else
            _health = _maxHealth;
        
        _healthbarSetter._healthChanged.Invoke();
    }
    
    public void Damage(int damagePoints)
    {
        if (_health > _minHealth)
            _health -= damagePoints;
        else
            _health = _minHealth;

        _healthbarSetter._healthChanged.Invoke();
    }

    public int GetHealth()
    {
        return _health;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }
}
