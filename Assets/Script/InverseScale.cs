using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseScale : MonoBehaviour
{
    private Transform parentTransform;
  
  

    void Start()
    {
 
        parentTransform = transform.parent;
        //try
        
    }

    void Update()
    {
        if (parentTransform)
        {
            // Inverse the scale
            transform.localScale = new Vector3(
                1 / parentTransform.localScale.x,
                1 / parentTransform.localScale.y,
                1 / parentTransform.localScale.z
            );
         
        }
    }
}
