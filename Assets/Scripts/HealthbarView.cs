using UnityEngine;
using UnityEngine.UI;

public class HealthbarView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _healthbarPrefab;
    [SerializeField] private Transform _container;
    
    private Scrollbar _scrollbar;
    private Healthbar _healthbar;

    private float normalizedValue;

    private void Start()
    {
        GameObject healthbarObject = Instantiate(_healthbarPrefab, _container.transform);
       
        _healthbar = _player.Healthbar;
        _healthbar._healthChanged += Render;

        _scrollbar = healthbarObject.GetComponentInChildren<Scrollbar>();
        
        Render();
    }

    private void OnDisable()
    {
        _healthbar._healthChanged -= Render;
    }

    public void Render()
    {
        normalizedValue = (float)_healthbar.HealthValue / (float)_healthbar.MaxHealthValue;
    }

    private void Update()
    {
        if (_scrollbar.value != normalizedValue)
            _scrollbar.value = Mathf.MoveTowards(_scrollbar.value, normalizedValue, Time.deltaTime);
    }
}
