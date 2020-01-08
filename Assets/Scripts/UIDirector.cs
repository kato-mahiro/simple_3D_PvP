using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class UIDirector : MonoBehaviour
{

    public float sp =1.0f;
    public float hp =1.0f;
    Slider spslider1;
    Slider hpslider1;

    public void Start()
    {
        // スライダーを取得する
        spslider1 = GameObject.Find("SPBar1").GetComponent<Slider>();
        hpslider1 = GameObject.Find("HPBar1").GetComponent<Slider>();
    }

    public void minus()
    {
        Debug.Log(this.sp);
        this.sp -= 0.3f;
    }

    public void Update()
    {
        sp += 0.004f;
        if (sp > 1)
        {
            sp=1;
        }
        else if (sp < 0)
        {
            sp = 0;
        }

        // spゲージに値を設定
        spslider1.value = sp;
        hpslider1.value = hp;
    }
}
