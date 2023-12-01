using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{

    public enum State {

        Swing,
        Extension,
        Takeback,
    }

    public State Mystate;
    private float speed = 60f; //the speed for the hook to swing
    private Vector3 v3;
    private float Length =1;
    private float LSpeed = 3.0f;
    public Transform go;


    // Start is called before the first frame update
    void Start()
    {
        v3 = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mystate == State.Swing)
        {

            OnSwing();
            //trigger hook extension
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Mystate = State.Extension;
            }


        }
        else if (Mystate == State.Extension)
        {

            OnExtension();
            


        } else if (Mystate == State.Takeback)
        {
            OnTakebak();
        }




    }



    //-----------------State code

    private void OnSwing()
    {
        transform.Rotate(v3 * speed * Time.deltaTime);//rotation 360o
        //controll rotation degree
        if(transform.localRotation.z > 0.45f)
        {
            v3 = Vector3.back;//geos the left swing
        }
        else if (transform.localRotation.z < -0.45f)
        {
            v3 = Vector3.forward;//goes right swing
        }

    }


    private void OnExtension()
    {
        
        Length += Time.deltaTime * LSpeed;
        transform.localScale = new Vector3(transform.localScale.x, Length, transform.localScale.z);
     
        if(Length > 15)
        {
            Mystate = State.Takeback;
        }
    }

    private void OnTakebak()
    {
        Length -= Time.deltaTime * LSpeed;
        transform.localScale = new Vector3(transform.localScale.x, Length, transform.localScale.z);
        //when to stop
        if (Length <= 2)
        {
            Length = 2;
            Mystate = State.Swing;
        }
    }



}
