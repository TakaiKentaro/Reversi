using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT10 : MonoBehaviour
{
    GameController10x10 m_gameController10X10;
    Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_gameController10X10 = GameObject.Find("GameManager").GetComponent<GameController10x10>();
        m_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (m_gameController10X10.player)
        {
            case GameController10x10.COLOR.BLACK:
                colorText = "黒";
                m_text.color = Color.black;
                break;
            case GameController10x10.COLOR.WHITE:
                colorText = "白";
                m_text.color = Color.white;
                break;
            default:
                break;
        }
        m_text.text = colorText;
    }
}
