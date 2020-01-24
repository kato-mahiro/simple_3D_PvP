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
        logtext = "";
        logtext += p1.transform.position.x;
        logtext += ",";
        logtext += p1.transform.position.y;
        StreamWriter sw = new StreamWriter("../LogData.txt", true);
        sw.WriteLine(logtext);
        sw.Flush();
        sw.Close();
    }
}
