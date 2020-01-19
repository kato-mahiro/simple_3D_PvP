using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameCollisionController2 : MonoBehaviour
{
    GameObject hpbar;
    UIDirector script;

    // Start is called before the first frame update
    void Start()
    {
        hpbar = GameObject.Find("BarCtrl");
        script = hpbar.GetComponent<UIDirector>();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // hit.gameObjectで衝突したオブジェクト情報が得られる
        if(hit.gameObject.name == "Flame(Clone)" || hit.gameObject.name == "Fireball(Clone)")
        {
            script.damage2();
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}
