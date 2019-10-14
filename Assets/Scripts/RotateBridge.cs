using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var v = new Vector3(0f, 0.5f, 0f);
        transform.Rotate(v);
    }
}
