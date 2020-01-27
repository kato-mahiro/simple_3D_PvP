using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{

    string logtext = "";

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 20;
        logtext = "=== Start Logging === ";
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.frameCount);
        GameObject p1 = GameObject.Find("Player");
        GameObject p2 = GameObject.Find("Player2");

        logtext = "";
        logtext += p1.transform.position.x;
        logtext += ", ";
        logtext += p1.transform.position.y;
        logtext += ", ";
        logtext += p2.transform.position.x;
        logtext += ", ";
        logtext += p2.transform.position.y;
        logtext += ", ";

        //Player1の入力(コントローラから)
        if(Input.GetAxis("Horizontal") > 0) {logtext += '>' ;}
        else{ logtext += '-'; }

        if(Input.GetAxis("Horizontal") < 0) {logtext += '<' ;}
        else{ logtext += '-'; }

        if(Input.GetButtonDown("Jump")) {logtext += 'J' ;}
        else{ logtext += '-'; }

        if(Input.GetButtonDown("Fire1")) {logtext += 'F' ;}
        else{ logtext += '-'; }

        //Player2の入力(キーボード) j,k,l,space
        if(Input.GetKey(KeyCode.L)){ logtext += 'l'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.J)){ logtext += 'j'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.Space)){ logtext += 'S'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.K)){ logtext += 'k'; }
        else{ logtext += '-'; }

        StreamWriter sw = new StreamWriter("../LogData.txt", true);
        sw.WriteLine(logtext);
        sw.Flush();
        sw.Close();
    }
}
