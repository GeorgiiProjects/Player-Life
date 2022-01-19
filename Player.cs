using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _minHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _damage;
    [SerializeField] private float _healing;

    private float _actualHealth;

    public float MaxHealth => _maxHealth;

    public event UnityAction<float> HealthAdjusted;

    private void Start()
    {
        _actualHealth = _maxHealth;
    }

    public void TakeDamage()
    {
        _actualHealth -= _damage;

        if (_actualHealth < _minHealth)
        {
            _actualHealth = _minHealth;
        }
        HealthAdjusted?.Invoke(_actualHealth);
    }

    public void RestoreHealth()
    {
        _actualHealth += _healing;

        if (_actualHealth > _maxHealth)
        {
            _actualHealth = _maxHealth;
        }
        HealthAdjusted?.Invoke(_actualHealth);
    }
}
