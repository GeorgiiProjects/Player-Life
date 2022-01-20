using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _glide;

    private Coroutine _coroutine;
    private Slider _slider;

    private void OnEnable()
    {
        _player.HealthAdjusted += ModifyHealth;
    }

    private void OnDisable()
    {
        _player.HealthAdjusted -= ModifyHealth;
    }

    private void Start()
    {
        Setup();      
    }

    private void Setup()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.MaxHealth;
    }

    private void ModifyHealth(float health)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(SetCurrentHealth(health));
    }

    private IEnumerator SetCurrentHealth(float currentHealth)
    {
        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _glide * Time.deltaTime);
            yield return null;
        }
    }
}


