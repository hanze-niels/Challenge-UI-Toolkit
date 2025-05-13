using UnityEngine;
using UnityEngine.Events;

public class BoxBehaviour : MonoBehaviour
{
    [SerializeField] private UnityEvent boxClickedEvent;

    //when the box is clicked, trigger the event and destroy the box
    private void OnMouseDown()
    {
        boxClickedEvent.Invoke();
        Destroy(gameObject);
    }
}
