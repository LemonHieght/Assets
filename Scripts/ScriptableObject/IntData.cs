using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 1;

    public void ChangeValue(int number)
    {
        value += number;
    }
    
}
