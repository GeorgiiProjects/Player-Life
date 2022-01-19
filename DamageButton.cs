using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;

    public void MakeDamage()
    {
        _player.TakeDamage();
    }
}
