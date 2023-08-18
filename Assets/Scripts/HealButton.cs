using Interfaces;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private GameObject _person;
    [SerializeField] private int _healPoints;
    
    public void OnPressed()
    {
        if (_person.TryGetComponent(out IHealthAbility person))
            person.Heal(_healPoints);
        else
            Debug.LogError("Created object hasn't IHealthAbility");
    }
}
