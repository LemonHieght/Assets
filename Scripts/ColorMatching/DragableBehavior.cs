using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DragableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offSet;

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

        }
    }

    public void OnMouseUp()
    {
        draggable = false;
    }
}
