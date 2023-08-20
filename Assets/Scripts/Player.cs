using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _pointsPerAction;
    
    private Health _health;

    private void Awake()
    {
        _health = new Health(_maxHealth);
    }

    public Health Health => _health;

    public void Heal()
    {
        _health.AddHealth(_pointsPerAction);
    }
    
    public void Damage()
    {
        _health.ApplyDamage(_pointsPerAction);
    }
}
