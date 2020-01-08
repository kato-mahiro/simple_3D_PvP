using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class UIDirector : MonoBehaviour
{

    public float hp =1.0f;
    Slider _slider;


    public void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    public void minus()
    {
        Debug.Log(this.hp);
        this.hp -= 0.3f;
    }

    public void Update()
    {
        // HP上昇
        hp += 0.004f;
        if (hp > 1)
        {
            hp=1;
        }
        else if (hp < 0)
        {
            hp = 0;
        }

        // HPゲージに値を設定
        _slider.value = hp;
    }
}
