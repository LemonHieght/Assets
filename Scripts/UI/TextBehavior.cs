using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    public UnityEvent startEvent;
    public string preText;
    
    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateText(FloatData obj)
    {
        textObj.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    public void UpdateText(IntData obj)
    {
        textObj.text =preText + obj.value.ToString( CultureInfo.InvariantCulture);
    }
    
    public void UpdateText(string obj)
    {
        textObj.text =preText + obj.ToString( CultureInfo.InvariantCulture);
    }
}
