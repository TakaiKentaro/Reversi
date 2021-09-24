using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT10 : MonoBehaviour
{
    GameController10x10 gameController10X10;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        gameController10X10 = GameObject.Find("GameManager").GetComponent<GameController10x10>();
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (gameController10X10.player)
        {
            case GameController10x10.COLOR.BLACK:
                colorText = "黒";
                break;
            case GameController10x10.COLOR.WHITE:
                colorText = "白";
                break;
            default:
                break;
        }
        text.text = "次の番：" + colorText;
    }
}
