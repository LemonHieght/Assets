using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class DragableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offSet;
    public UnityEvent startDragEvent, endDragEvent;

    private void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {

        offSet = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;

        yield return new WaitForFixedUpdate();
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offSet;
            transform.position = position;
            
            startDragEvent.Invoke();

        }
    }

    public void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
