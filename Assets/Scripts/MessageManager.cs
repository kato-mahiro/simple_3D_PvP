using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class MessageManager : MonoBehaviour
{

    Text myText;

    // Use this for initialization
    void Start()
    {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
        myText.text = "  ";//テキストの変更
    }

    public void BlueWin(bool is_blue_win)
    {
        if(is_blue_win)
        {
            myText.text = "ゲーム終了 --- \n 青の勝ちです";
        }
        else
        {
            myText.text = "ゲーム終了 --- \n オレンジの勝ちです";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
