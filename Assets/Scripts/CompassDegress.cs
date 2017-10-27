using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassDegress : MonoBehaviour {

    Text speedometer;

    // Next update in second
    private int nextUpdate = 1;

    void Start()
    {
        speedometer = GetComponent<Text>();
    }

    // Update is called once per frame overridden to do every second ;-p
    void Update()
    {

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
        if (Time.time >= 9)
        {
            speedometer.text = "75";
        }

        if (Time.time >= 10)
        {
            speedometer.text = "60";
        }

        if (Time.time >= 11)
        {
            speedometer.text = "45";
        }

        if (Time.time >= 12)
        {
            speedometer.text = "30";
        }

        if (Time.time >= 13)
        {
            speedometer.text = "15";
        }

        if (Time.time >= 14)
        {
            speedometer.text = "5";
        }

        if (Time.time >= 15)
        {
            speedometer.text = "3";
        }

        if (Time.time >= 16)
        {
            speedometer.text = "1";
        }

        if (Time.time >= 17)
        {
            speedometer.text = "1";
        }

        if (Time.time >= 18)
        {
            speedometer.text = "3";
        }

        if (Time.time >= 20)
        {
            speedometer.text = "30";
        }

        if (Time.time >= 23)
        {
            speedometer.text = "40";
        }


        if (Time.time >= 26)
        {
            speedometer.text = "50";
        }

        if (Time.time >= 27)
        {
            speedometer.text = "55";
        }

        if (Time.time >= 28)
        {
            speedometer.text = "62";
        }

        if (Time.time >= 29)
        {
            speedometer.text = "75";
        }
    }
}
