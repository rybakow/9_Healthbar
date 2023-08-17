using Interfaces;
using UnityEngine;

public class HealthbarSetter : MonoBehaviour
{
    [SerializeField] private HealthbarView _healthbar;
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _person;

    private void Awake()
    {
        Render();
    }

    private void Render()
    {
        var view = Instantiate(_healthbar, _container.transform) as HealthbarView;
        Debug.Log(view.gameObject.name);
        //view.Render(_person.GetHealth());
    }
}
