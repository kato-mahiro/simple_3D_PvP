using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireballController : MonoBehaviour
{
    public float max_lifespan;
    public float fire_power;
    float lifetime = 0.0f;
    bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject obj = (GameObject)Resources.Load("Flame");
        Instantiate(obj, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        //transform.Translate(transform.forward * 0.5f * -1);
        
        if(isFirst)
        {
            isFirst = false;
            Rigidbody rb = this.GetComponent<Rigidbody> ();
            //Vector3 force = new Vector3(transform.forward);
            Vector3 force = /*this.gameObject.transform.up * fire_power +*/
                            this.gameObject.transform.forward *  fire_power;
            rb.AddForce(force, ForceMode.Impulse);
        }
        if(lifetime >= max_lifespan)
        {
            Destroy(this.gameObject);
        }
        
    }
}
