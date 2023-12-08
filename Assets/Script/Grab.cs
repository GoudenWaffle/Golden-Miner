using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public Transform go;

    // public GameObject GrabSpeed;

    public Hook hookScript; // Reference to the Hook script

   

    private void Start()
    {
        // Find the Hook component in the parent GameObject
        hookScript = go.parent.GetComponent<Hook>();

        if (hookScript != null)
        {
           
            float hookSpeed = hookScript.LSpeed;
            // the hookspeed here will = to the Lspeed in hook script
        }
    }

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

        if (hookScript != null)
        {
            if (collision.gameObject.tag == "sG")
            {
                hookScript.LSpeed = 12.0f; // Set speed for sG tag
            }
            else if (collision.gameObject.tag == "mG")
            {
                hookScript.LSpeed = 5.0f; // Set speed for mG tag
            }
            else if (collision.gameObject.tag == "bG")
            {
                hookScript.LSpeed = 2.0f; // Set speed for bG tag
            }
            // Set the state to Takeback
            hookScript.Mystate = Hook.State.Takeback;
            //hookScript.LSpeed = hookScript.originalSpeed;
           // hookScript.ResetSpeed();
        
    }
    
    }








}
