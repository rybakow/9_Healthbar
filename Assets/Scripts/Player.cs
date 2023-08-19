using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _pointsPerAction;
    
    private Healthbar _healthbar;

    private void Awake()
    {
        _healthbar = new Healthbar(_maxHealth);
    }

    public Healthbar Healthbar => _healthbar;

    public void Heal()
    {
        _healthbar.IncreaseHealth(_pointsPerAction);
    }
    
    public void Damage()
    {
        _healthbar.DecreaseHealth(_pointsPerAction);
    }
}
