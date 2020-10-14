using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaacterMouseLookAt : CharacterBehaviour
{
    public Vector3Data mouseLocation;
    
      protected override void OnRotate()
      {
          Transform transform1;
          (transform1 = transform).LookAt(mouseLocation.value);
          var transformRotation = transform.eulerAngles;
          transformRotation.x = 0;
          transformRotation.y -= 90;
          transform.rotation = Quaternion.Euler(transformRotation); 
      } 
}
