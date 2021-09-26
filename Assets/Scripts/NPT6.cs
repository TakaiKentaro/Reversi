using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPT6 : MonoBehaviour
{
    GameController6x6 m_gameController6X6;
    Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_gameController6X6 = GameObject.Find("GameManager").GetComponent<GameController6x6>();
        m_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string colorText = "";
        switch (m_gameController6X6.player)
        {
            case GameController6x6.COLOR.BLACK:
                colorText = "黒";
                m_text.color = Color.black;
                break;
            case GameController6x6.COLOR.WHITE:
                colorText = "白";
                m_text.color = Color.white;
                break;
            default:
                break;
        }
        m_text.text = colorText;
    }
}
