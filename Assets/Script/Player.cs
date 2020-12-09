using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    //[SerializeField] private float _pathTime;
    //[SerializeField] private float _pathRuningTime;
    [SerializeField] private float _speed;

    public event UnityAction<float> HealthChanged;
    private float _changedHealth;


    private void Start()
    {
        _changedHealth = _health;
        HealthChanged?.Invoke(_health);
    }

    private void Update()
    {
        _health = Mathf.Lerp(_health, _changedHealth, _speed);
        HealthChanged?.Invoke(_health);

        //if (_health != _changedHealth)
        //{
        //    //_pathRuningTime += Time.deltaTime;
        //    //_health = Mathf.Lerp(_health, _changedHealth, _pathRuningTime / _pathTime);
            
        //    HealthChanged?.Invoke(_health);
        //}
        //else
        //    _pathRuningTime = 0;

    }

    public void ApplyDamage(float damage)
    {
        _changedHealth -= damage;
        //HealthChanged?.Invoke(_health);
    }

    public void ApplyHealth(float health)
    {
        _changedHealth += health;
        //HealthChanged?.Invoke(_health);
    }
}
