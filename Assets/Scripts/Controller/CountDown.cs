using System;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    // contador en reversa, tengo el tiempoqd3el SO el cual sera el tiempo mximo, el current va a ser al momento de instanciar la semilla, y el tiempo minimo sera el valor 0.
    // necesito que al momento de llegar a 0, pase al arbol
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
