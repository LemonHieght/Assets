using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public IDData idObj;
    public UnityEvent startEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }
}
