using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class UIDirector : MonoBehaviour
{
    public AudioClip damagesound;
    AudioSource audioSource;

    public float sp =1.0f;
    public float hp =1.0f;
    public float sp2 =1.0f;
    public float hp2 =1.0f;
    public Slider spslider1;
    public Slider hpslider1;
    public Slider spslider2;
    public Slider hpslider2;

    public void Start()
    {
        // スライダーを取得する
        spslider1 = GameObject.Find("SPBar1").GetComponent<Slider>();
        hpslider1 = GameObject.Find("HPBar1").GetComponent<Slider>();
        spslider2 = GameObject.Find("SPBar2").GetComponent<Slider>();
        hpslider2 = GameObject.Find("HPBar2").GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
    }

    public void minus()
    {
        //Debug.Log(this.sp);
        this.sp -= 0.3f;
    }

    public void minus2()
    {
        //Debug.Log(this.sp);
        this.sp2 -= 0.3f;
    }

    public void damage()
    {
        audioSource.PlayOneShot(damagesound);
        this.hp -= 0.005f;
    }

    public void damage2()
    {
        audioSource.PlayOneShot(damagesound);
        this.hp2 -= 0.005f;
    }

    public void Update()
    {
        sp += 0.004f;
        sp2 += 0.004f;
        if (sp > 1)
        {
            sp=1;
        }
        else if (sp < 0)
        {
            sp = 0;
        }

        if (sp2 > 1)
        {
            sp2=1;
        }
        else if (sp2 < 0)
        {
            sp2 = 0;
        }

        // spゲージに値を設定
        spslider1.value = sp;
        hpslider1.value = hp;
        spslider2.value = sp2;
        hpslider2.value = hp2;
    }
}
