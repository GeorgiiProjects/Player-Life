using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _damage;

    public void MakeDamage()
    {
        _player.Damage(_damage);
    }
}
