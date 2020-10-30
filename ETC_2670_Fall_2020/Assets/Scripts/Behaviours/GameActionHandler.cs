using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameActionHand gameAction;
    public UnityEvent handlerEvent;
    public float holdTime = 3f;
    

    private void Start()
    {
        gameAction.action += ActionHandler;
    }
    
    private void ActionHandler()
    {
        Invoke(nameof(handlerEvent), holdTime);
    }

    private void OnActionHandler()
    {
        handlerEvent.Invoke();
    }
}


