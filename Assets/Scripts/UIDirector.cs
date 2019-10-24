using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDirector : MonoBehaviour
{
    GameObject staminaGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.staminaGauge = GameObject.Find("staminaGauge");

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void DecreaseStamina()
    {
        this.staminaGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
