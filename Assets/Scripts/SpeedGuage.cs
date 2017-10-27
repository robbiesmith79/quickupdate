using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedGuage : MonoBehaviour {

    // Use this for initialization

    public Texture[] textures;

    // Next update in second
    private int nextUpdate = 1;

    void Start()
    {
        ChangeTexture(0); // load the 0th image in the resources array. This comes into play as well when the script loops.
    }

    // Update is called once per frame overridden to do every second ;-p
    void Update()
    {

        if (Time.timeSinceLevelLoad >= nextUpdate)
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
        if (Time.timeSinceLevelLoad >= 4)
        {
            ChangeTexture(0);
        }

        if (Time.timeSinceLevelLoad >= 5)
        {
            ChangeTexture(1);
        }

        if (Time.timeSinceLevelLoad >= 6)
        {
            ChangeTexture(2);
        }

        if (Time.timeSinceLevelLoad >= 10)
        {
            ChangeTexture(3);
        }

        if (Time.timeSinceLevelLoad >= 16)
        {
            ChangeTexture(4);
        }

        if (Time.timeSinceLevelLoad >= 17)
        {
            ChangeTexture(5);
        }

        if (Time.timeSinceLevelLoad >= 20)
        {
            ChangeTexture(6);
        }

        if (Time.timeSinceLevelLoad >= 26)
        {
            ChangeTexture(7);
        }

        if (Time.timeSinceLevelLoad >= 27)
        {
            ChangeTexture(8);
        }

        if (Time.timeSinceLevelLoad >= 34)
        {
            // turn back time. belongs to Cher
        }
    }

    void ChangeTexture(int spot)
    {
        GetComponent<RawImage>().texture = textures[spot];
    }
}
