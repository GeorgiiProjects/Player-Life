using UnityEngine;

public class HealthButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _healing;

    public void RestoreHealth()
    {
        _player.RestoreHealth(_healing);
    }
}
