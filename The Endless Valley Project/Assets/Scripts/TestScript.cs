using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string myStartMessage;
    public string myUpdateMessage;
//    public int time;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(myStartMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(myUpdateMessage);
//        time += 1;
//        Debug.Log(time);
    }
}
