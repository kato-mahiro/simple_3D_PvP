using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour
{
    public float max_lifespan;
    float lifetime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        //transform.Translate(transform.forward * 0.5f * -1);
        
        if(lifetime >= max_lifespan)
        {
            Destroy(this.gameObject);
        }
        
    }
}
