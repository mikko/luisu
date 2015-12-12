using UnityEngine;
using System.Collections;
using System;

public class Screencap : MonoBehaviour {

    DateTime prevCapture;

	// Use this for initialization
	void Start () {
        prevCapture = DateTime.Now;
        print(Application.persistentDataPath);
        SaveScreenshot();
    }
	
	// Update is called once per frame
	void Update () {
        if (DateTime.Now.Subtract(prevCapture).Seconds > 4)
        {
            print(DateTime.Now.ToString());
            prevCapture = DateTime.Now;
            SaveScreenshot();
        }
	}

    void SaveScreenshot()
    {
        Application.CaptureScreenshot("Screenshots/capture_" + DateTime.Now.Ticks + ".png");
    }
}
