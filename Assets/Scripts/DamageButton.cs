using Interfaces;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private GameObject _person;
    [SerializeField] private int _damagePoints;

    public void OnPressed()
    {
        if (_person.TryGetComponent(out IHealthAbility person))
            person.Damage(_damagePoints);
        else
            Debug.LogError("Created object hasn't IHealthAbility");
    }
}
