using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderOfHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

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
        _slider.value = value;
    }
}
