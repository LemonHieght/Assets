using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 coordinates;

    public void SetPosistion(Vector3 number)
    {
        coordinates = number;
    }

    public void SetPosistion(Transform obj)
    {
        coordinates = obj.position;
    }

    public void UsePosistion(Transform obj)
    {
        obj.position = coordinates;
    }
}
