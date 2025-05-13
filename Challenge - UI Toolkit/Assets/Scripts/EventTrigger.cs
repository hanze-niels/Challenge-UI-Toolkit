using System;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    //declare the variable of type UnityEvent
    [SerializeField] private UnityEvent _boxClicked;

    private void OnMouseDown()
    {
        //trigger the event
        _boxClicked.Invoke();
    }
}
