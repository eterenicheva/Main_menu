using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    public event UnityAction<float> HealthChanged;


    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void ApplyDamage(float damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

    }

    public void ApplyHealth(float health)
    {
        _health += health;
        HealthChanged?.Invoke(_health);

    }
}
