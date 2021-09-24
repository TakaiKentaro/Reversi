using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{   
    public void OnStart()
    {
        SceneManager.LoadScene("SelectMode");
    }
    public void Back()
    {
        SceneManager.LoadScene("title");
    }
    public void Four()
    {
        SceneManager.LoadScene("4x4Game");
    }
    public void Six()
    {
        SceneManager.LoadScene("6x6Game");
    }
    public void Eeight()
    {
        SceneManager.LoadScene("Game");
    }
    public void Ten()
    {
        SceneManager.LoadScene("10x10Game");
    }
}
