using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour

{
    public const int healthAmount = 10;
    public int currentHealth = healthAmount;
   // public Vector3Data healthAmount;
    
    //public int death = 0;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (healthAmount <= 0)
        {
           currentHealth = 0;
        }
    }

    public void HealthAdd(int amount)
    {
        currentHealth += amount;
        if (currentHealth >= 10)
        {
            currentHealth = 10;
        }
    }
    
}
