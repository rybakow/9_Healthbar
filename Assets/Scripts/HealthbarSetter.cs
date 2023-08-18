using Interfaces;
using UnityEngine;
using UnityEngine.Events;

public class HealthbarSetter : MonoBehaviour
{
    [SerializeField] private HealthbarView _healthbarPrefab;
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _person;
    
    private int _maxHealthValue;
    private HealthbarView _healthbarView;
    
    public UnityEvent _healthChanged;
    
    private void Awake()
    {
        Render();
    }

    public void Render()
    {
        if (_person.TryGetComponent(out IHealthAbility person))
        {
            if (_healthbarView == null)
                _healthbarView = Instantiate(_healthbarPrefab, _container.transform);

            _healthbarView.Render(new Healthbar(person.GetMaxHealth(), person.GetHealth()));
        }
    }
}
