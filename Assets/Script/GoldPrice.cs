using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPrice : MonoBehaviour
{

    public int Value;//price
    private GameUI GaUI;




    // Start is called before the first frame update
    void Start()
    {
        GaUI = GameObject.Find("Canvas").GetComponent<GameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
