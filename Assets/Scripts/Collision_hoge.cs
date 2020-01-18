using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_hoge : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // hit.gameObjectで衝突したオブジェクト情報が得られる
        if(hit.gameObject.name == "Flame(Clone)")
        {
            Debug.Log("アツゥイ");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
