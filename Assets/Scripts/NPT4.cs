using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT4 : MonoBehaviour
{
    GameController4x4 gameController4X4;
    Text text;
    void Start()
    {
        gameController4X4 = GameObject.Find("GameManager").GetComponent<GameController4x4>();
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (gameController4X4.player)
        {
            case GameController4x4.COLOR.BLACK:
                colorText = "黒";
                break;
            case GameController4x4.COLOR.WHITE:
                colorText = "白";
                break;
            default:
                break;
        }
        text.text = "次の番：" + colorText;
    }
}
