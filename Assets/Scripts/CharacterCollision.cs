using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
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
        if(hit.gameObject.name == "Player2")
        {
            if((this.transform.position.y - hit.transform.position.y) >= 0.3f)
            {
                script.Ldamage2();
            }
            else if((this.transform.position.y - hit.transform.position.y) <= -0.3f)
            {
                script.Ldamage();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
