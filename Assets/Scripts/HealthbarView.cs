using UnityEngine;
using UnityEngine.UI;

public class HealthbarView : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Scrollbar _scrollbar;

    private int _healthValue;
    
    public void Render(int healthValue)
    {
        _healthValue = healthValue;
        Debug.Log(_healthValue);
    }
}
