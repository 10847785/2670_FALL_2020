using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Health : MonoBehaviour

{
    public Vector3Data healthAmount;
    
    public int death = 0;

    public void TakeDamage(int amount)
    {
        healthAmount -= amount;
        if (healthAmount <= 0)
        {
            healthAmount = 0;
        }
    }
    
}
