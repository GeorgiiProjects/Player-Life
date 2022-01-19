using UnityEngine;

public class HealthButton : MonoBehaviour
{
    [SerializeField] private Player _player;

    public void RestoreHealth()
    {
        _player.RestoreHealth();
    }
}
