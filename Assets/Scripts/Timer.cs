using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timerImg;
    [SerializeField] private Text _timerText;
    [SerializeField] private float _duration;
    private float _currentTime;
    
    void Start()
    {
        _currentTime = _duration;
        _timerText.text = _currentTime.ToString();
        StartCoroutine(UpdateTime());
    }

    void Update()
    {
        
    }

    private IEnumerator UpdateTime()
    {
        while (_currentTime > 0)
        {
            _timerImg.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timerText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;
        }
    }
}
