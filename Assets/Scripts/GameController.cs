using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    enum COLOR
    {
        EMPTY,  //空欄 = 0
        BLACK,  //黒色 = 1
        WHITE   //白色 = 2
    }

    const int WIDTH = 8, HEIGHT = 8;//ここでボードの大きさを決める(8x8)

    [SerializeField] GameObject Black;//黒の駒
    [SerializeField] GameObject White;//白の駒
    [SerializeField] GameObject BoardEmpty;//盤

    [SerializeField]GameObject boardDisplay = null;//盤のGameObject

    COLOR[,] board = new COLOR[WIDTH, HEIGHT];
    void Start()
    {
        Initialize(); //盤面の初期値を設定
        ShowBoard(); //盤面を表示
    }
    void Initialize()
    {
        board[3, 3] = COLOR.WHITE;
        board[3, 4] = COLOR.BLACK;
        board[4, 3] = COLOR.BLACK;
        board[4, 4] = COLOR.WHITE;
    }
    void ShowBoard()
    {
        for (int v = 0; v < HEIGHT; v++)
        {
            for (int h = 0; h < WIDTH; h++)
            {
                // boardの色に合わせて適切なPrefabを取得
                GameObject piece = GetPrefab(board[h, v]);

                //取得したPrefabをboardDisplayの子オブジェクトにする
                piece.transform.SetParent(boardDisplay.transform);
            }
        }
    }
    GameObject GetPrefab(COLOR color)
    {
        GameObject prefab;
        switch (color)
        {
            case COLOR.EMPTY:   //空欄の時
                prefab = Instantiate(BoardEmpty);
                break;
            case COLOR.BLACK:   //黒の時
                prefab = Instantiate(Black);
                break;
            case COLOR.WHITE:   //白の時
                prefab = Instantiate(White);
                break;
            default:            //それ以外の時(ここに入ることは想定していない)
                prefab = null;
                break;
        }
        return prefab; //取得したPrefabを返す
    }
}
