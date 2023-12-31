using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TMP_Text Money;
    public TMP_Text Target;//money goal
    public TMP_Text Level;
    public TMP_Text LevelTime;

    public int money;
    public int target;
    public int level;
    public float levelTime;

    public string targetScene;
    public string targetScene2;

    // Start is called before the first frame update
    void Start()
    {
        //make the ui int number
        Money.text = money.ToString();
        Target.text = target.ToString();
        LevelTime.text = levelTime.ToString();
        Level.text = level.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        //time count down
        LevelTime.text = (levelTime -= Time.deltaTime).ToString("0");
        if(levelTime<= 0)
        {
            levelTime = 0;
            SceneManager.LoadScene(targetScene);
        }
    }



    public void OnMoney (int Value)
    {
        money = money + Value;
        Money.text = money.ToString();

        if(money>= target)
        {
            SceneManager.LoadScene(targetScene2);
        }
    }
}
