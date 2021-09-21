﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextPlayerText : MonoBehaviour
{
    GameController gameController;
    Text text;
    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (gameController.player)
        {
            case GameController.COLOR.BLACK:
                colorText = "黒";
                break;
            case GameController.COLOR.WHITE:
                colorText = "白";
                break;
            default:
                break;
        }
        text.text = "次の番：" + colorText;
    }
}
