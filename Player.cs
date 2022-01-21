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
        _actualHealth = Mathf.Max(_actualHealth - damage, _minHealth);

        HealthAdjusted?.Invoke(_actualHealth);
    }

    public void Heal(float healing)
    {
        _actualHealth = Mathf.Min(_actualHealth + healing, _maxHealth);

        HealthAdjusted?.Invoke(_actualHealth);
    }
}
