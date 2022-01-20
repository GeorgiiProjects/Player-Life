using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _minHealth;
    [SerializeField] private float _maxHealth;

    private float _actualHealth;

    public float MaxHealth => _maxHealth;

    public event UnityAction<float> HealthAdjusted;

    private void Start()
    {
        _actualHealth = _maxHealth;
    }

    public void Damage(float damage)
    {
        _actualHealth = ((_actualHealth - damage) < _minHealth ? _minHealth : _actualHealth - damage);

        HealthAdjusted?.Invoke(_actualHealth);
    }

    public void Heal(float healing)
    {
        _actualHealth = ((_actualHealth + healing) > _maxHealth ? _maxHealth : _actualHealth + healing);

        HealthAdjusted?.Invoke(_actualHealth);
    }
}
