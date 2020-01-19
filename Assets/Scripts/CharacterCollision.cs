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
            Debug.Log(this.transform.position.y);
            Debug.Log(hit.transform.position.y);
            if((this.transform.position.y - hit.transform.position.y) >= 0.3f)
            {
                Debug.Log("P1の勝ち");
                script.damage2();
            }
            else if((this.transform.position.y - hit.transform.position.y) <= -0.3f)
            {
                Debug.Log("P2の勝ち");
                script.damage();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(hpbar);
    }
}
