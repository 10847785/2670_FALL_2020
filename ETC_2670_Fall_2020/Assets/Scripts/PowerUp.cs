using System;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public FloatData powerData;
    public float powerUpLevel = 0.1f;

    private void OnParticleTrigger(Collider other)
    {
        powerData.value += powerUpLevel;
    }
}
