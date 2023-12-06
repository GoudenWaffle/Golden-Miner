using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public string Game;


    public void ChangeScene()
    {
        // load
        SceneManager.LoadScene(Game);
    }
}
