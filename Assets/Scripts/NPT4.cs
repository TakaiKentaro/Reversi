using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT4 : MonoBehaviour
{
    GameController4x4 m_gameController4X4;
    Text m_text;
    void Start()
    {
        m_gameController4X4 = GameObject.Find("GameManager").GetComponent<GameController4x4>();
        m_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (m_gameController4X4.player)
        {
            case GameController4x4.COLOR.BLACK:
                colorText = "黒";
                m_text.color = Color.black;
                break;
            case GameController4x4.COLOR.WHITE:
                colorText = "白";
                m_text.color = Color.white;
                break;
            default:
                break;
        }
        m_text.text = colorText;
    }
}
