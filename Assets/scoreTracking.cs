using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTracking : MonoBehaviour
{
    Vector3 curPos = GameObject.FindGameObjectWithTag("cube1").transform.position;

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPos = GameObject.FindGameObjectWithTag("cube1").transform.position;
        if (curPos != lastPos)
        {
            SumScore.Add(1);
        }
        curPos = lastPos;
    }
}