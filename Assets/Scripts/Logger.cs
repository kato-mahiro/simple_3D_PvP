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

        if(Input.GetKey(KeyCode.D)){ logtext += 'D'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.A)){ logtext += 'A'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.Q)){ logtext += 'Q'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.W)){ logtext += 'W'; }
        else{ logtext += '-'; }
        if(Input.GetKey(KeyCode.LeftArrow)){ logtext += '<'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.RightArrow)){ logtext += '>'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.O)){ logtext += 'O'; }
        else{ logtext += '-'; }

        if(Input.GetKey(KeyCode.P)){ logtext += 'P'; }
        else{ logtext += '-'; }

        StreamWriter sw = new StreamWriter("../LogData.txt", true);
        sw.WriteLine(logtext);
        sw.Flush();
        sw.Close();
    }
}
