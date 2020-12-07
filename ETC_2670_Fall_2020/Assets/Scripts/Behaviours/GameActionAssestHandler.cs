using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActionAssestHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent handleEvent;

    private void OnEnable()
    {
        gameActionObj.action += ActionHandler;
    }
}
