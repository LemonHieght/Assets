using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public IDData idObj;
    public UnityEvent matchEvent, noMatchEvent, startEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj != null)
        {
            var otherID = tempObj.idObj;
            if (otherID==idObj)
            {
                matchEvent.Invoke();
                Debug.Log("Match");
            }
            else
            {
                noMatchEvent.Invoke();
                Debug.Log("No Match");
            }
        }
    }
}