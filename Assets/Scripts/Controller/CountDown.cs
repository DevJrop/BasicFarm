using System;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    private float remining;
    private float duration;
    Action onFinish;
    public void Init(float durationSeconds, Action finishCallBack)
    {
      remining = durationSeconds;
      duration = durationSeconds;
      onFinish = finishCallBack;
      
      counterText.text = Mathf.CeilToInt(remining).ToString();

      enabled = true;
    }
    private void Update()
    {
        remining -= Time.deltaTime;
        
        remining = Mathf.Clamp(remining, 0, duration);
        
        counterText.text = Mathf.CeilToInt(remining).ToString();

        if (remining <= 0 )
        {
            enabled = false;
            onFinish?.Invoke();
        }
    }
}
