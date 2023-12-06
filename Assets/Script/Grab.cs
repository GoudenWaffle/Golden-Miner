using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public Transform go;
   

    // Update is called once per frame
    void Update()
    {
        transform.position = go.position;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y,go.eulerAngles.z);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //once collide, the other obj will be child of this hand
        collision.transform.parent = transform;

        //have the item and hook goes back
        //taking state from other object
        go.parent.GetComponent<Hook>().Mystate = Hook.State.Takeback;

      //  if (Hook != null)
      //  {
      //      if (collision.gameObject.tag == "sG") 
      //      {
     //           Hook.ChangeLSpeed(7.0f);

      //      }
     //   }
    }


}
