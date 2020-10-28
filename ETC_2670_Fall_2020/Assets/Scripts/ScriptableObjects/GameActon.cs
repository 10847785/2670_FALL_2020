using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActon : ScriptableObject
{
   public UnityAction action;

   public void Raise()
   {
      action?.Invoke();
   }
}
