using UnityEngine;
using UnityEngine.Events;
public class MouseEventsBehaviour1 : MonoBehaviour
{
    public UnityEvent mouseDownEvent;

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
}
