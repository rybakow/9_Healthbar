using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    
    private Healthbar _healthbar;

    private void Awake()
    {
        _healthbar = new Healthbar(_maxHealth);
    }

    public Healthbar Healthbar => _healthbar;

    public void Heal(int healPoints)
    {
        _healthbar.IncreaseHealth(healPoints);
    }
    
    public void Damage(int damagePoints)
    {
        _healthbar.DecreaseHealth(damagePoints);
    }
}
