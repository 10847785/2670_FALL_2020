using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void OnDebug(string obj)
    {
        Debug.Log(obj);
    }
}
