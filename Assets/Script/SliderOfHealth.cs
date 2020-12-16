using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderOfHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private float _speed;

    private float _currentValueSlider;
    private float _newValueSlider;

    private void Update()
    {
        _currentValueSlider = Mathf.Lerp(_currentValueSlider, _newValueSlider, _speed);
        _slider.value = _currentValueSlider;
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnChangeHealth;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnChangeHealth;
    }

    private void OnChangeHealth(float value)
    {
        _newValueSlider = value;
    }
}
