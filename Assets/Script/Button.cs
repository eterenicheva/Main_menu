using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private int _value;
    [SerializeField] private float _waitTime;

    public void TakeDamage()
    {
        StartCoroutine(Damage());
    }

    public void TakeHealth()
    {
        StartCoroutine(Health());
    } 

    private IEnumerator Damage()
    {
        for (int i = 0; i < _value; i++)
        {
            _slider.value--;
            yield return new WaitForSeconds(_waitTime);
        }
    }

    private IEnumerator Health()
    {
        for (int i = 0; i < _value; i++)
        {
            _slider.value++;
            yield return new WaitForSeconds(_waitTime);
        }
    }
}
