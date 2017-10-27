using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedometerOverTime : MonoBehaviour {

    // Use this for initialization

    Text speedometer;

    // Next update in second
    private int nextUpdate = 1;

    void Start () {
        speedometer = GetComponent<Text>();
	}
	
	// Update is called once per frame overridden to do every second ;-p
	void Update () {

        if (Time.time >= nextUpdate)
        {
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            // Call your fonction
            UpdateEverySecond();
        }
           
    }

    void UpdateEverySecond()
    {
        
        // move the drone forward
        if (Time.time >= 4) { 
            speedometer.text = "8";
        }

        if (Time.time >= 5)
        {
            speedometer.text = "10";
        }

        if (Time.time >= 6)
        {
            speedometer.text = "12";
        }

        if (Time.time >= 10)
        {
            speedometer.text = "15";
        }

        if (Time.time >= 16)
        {
            speedometer.text = "5";
        }

        if (Time.time >= 17)
        {
            speedometer.text = "8";
        }

        if (Time.time >= 20)
        {
            speedometer.text = "13";
        }

        if (Time.time >= 26)
        {
            speedometer.text = "3";
        }

        if (Time.time >= 27)
        {
            speedometer.text = "0";
        }
    }
}
