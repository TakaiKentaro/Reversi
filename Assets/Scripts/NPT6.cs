using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT6 : MonoBehaviour
{
    GameController6x6 gameController6X6;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        gameController6X6 = GameObject.Find("GameManager").GetComponent<GameController6x6>();
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (gameController6X6.player)
        {
            case GameController6x6.COLOR.BLACK:
                colorText = "黒";
                break;
            case GameController6x6.COLOR.WHITE:
                colorText = "白";
                break;
            default:
                break;
        }
        text.text = "次の番：" + colorText;
    }
}
