using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _damagePoints;

    public void OnPressed()
    {
        _player.Damage(_damagePoints);
    }
}
