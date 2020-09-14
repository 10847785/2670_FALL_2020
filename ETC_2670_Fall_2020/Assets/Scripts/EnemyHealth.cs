using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : FloatData
{
   private void OnEnable()
   {
      value = 1f;
   }
}
