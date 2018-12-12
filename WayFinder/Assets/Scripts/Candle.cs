﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour {

    public GameObject player;
    public bool triggered;
	private Light candleLight;

	// Use this for initialization
	void Start () {
        triggered = false;
		candleLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (triggered == false)//concentration means more light as long as under max range of 20
            if (player.GetComponent<EEGStuff>().attention >= 50)
                if(candleLight.range<20.0f)
                    candleLight.range++;
        if (candleLight.range >= 20.0f)
            triggered = true;//shows when at max range the challenge to be completed
	}

    public void Default()
    {
        candleLight.range = 5.0f;
        triggered = false;
    }

}
