using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _healPoints;
    
    public void OnPressed()
    {
        _player.Heal(_healPoints);
    }
}
