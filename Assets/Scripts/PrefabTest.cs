using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{

    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Bullet");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }

    void Update()
    {
        GameObject obj = (GameObject)Resources.Load("Bullet");
        if(Input.GetKey(KeyCode.F))
        {
            //Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
            PlayerPosition = transform.position;
            Instantiate(obj, PlayerPosition, Quaternion.identity);
        }

    }

}
