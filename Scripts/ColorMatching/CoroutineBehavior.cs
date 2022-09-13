using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public IntData counterNum;
    public float secs = 1f;

    public UnityEvent startEvent, repeatEvent, endEvent;
    
    private WaitForSeconds _waitForSecondsObj;
    private WaitForFixedUpdate _waitForFixedUpdateObj;
    IEnumerator Start()
    {
        _waitForSecondsObj = new WaitForSeconds(secs);
        _waitForFixedUpdateObj = new WaitForFixedUpdate();
        
        startEvent.Invoke();

        while (counterNum.value > 0)
        {
            Debug.Log(counterNum);
            repeatEvent.Invoke();
            counterNum.value--;
            
            yield return _waitForSecondsObj;
        }
        
        endEvent.Invoke();
    }
}
