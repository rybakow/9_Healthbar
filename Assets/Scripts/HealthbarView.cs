using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _healthbarPrefab;
    [SerializeField] private Transform _container;
    
    private Scrollbar _scrollbar;
    private Health _health;

    private float normalizedValue;

    private Coroutine _movingScrollbar;

    private void OnDisable()
    {
        _health.HealthChanged -= Render;
    }

    private void Start()
    {
        GameObject healthbarObject = Instantiate(_healthbarPrefab, _container.transform);

        _health = _player.Health;
        _health.HealthChanged += Render;

        _scrollbar = healthbarObject.GetComponentInChildren<Scrollbar>();

        Render(_health.MaxValue);
    }    

    public void Render(int actualValue)
    {
        normalizedValue = (float)actualValue / (float)_health.MaxValue;

        if (_movingScrollbar == null)
        {
            _movingScrollbar = StartCoroutine(MovingScrollbar(normalizedValue));
        } 
        else
        {
            StopCoroutine(_movingScrollbar);
            _movingScrollbar = StartCoroutine(MovingScrollbar(normalizedValue));
        }
    }

    private IEnumerator MovingScrollbar (float normalizedValue)
    {
        while(_scrollbar.value != normalizedValue)
        {
            _scrollbar.value = Mathf.MoveTowards(_scrollbar.value, normalizedValue, Time.deltaTime);

            yield return null;
        }
    }
}
