using UnityEngine;
using UnityEngine.Events;

public class BoolEventTrigger : MonoBehaviour
{
    public BoolData boolData;
    public UnityEvent onTrue; 
    
    
    public void BoolTriggerEvent()
    {
        if (boolData.value)
        {
            onTrue.Invoke();
        }
    }   
    
}
