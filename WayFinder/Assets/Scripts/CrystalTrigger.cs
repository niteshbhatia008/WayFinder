﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalTrigger : MonoBehaviour {

    public GameObject player;
    Vector3 defaultposition;
    public bool triggered;

    void Start()
    {
        defaultposition = transform.position;
        triggered = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(transform.position!=defaultposition)//if the crystal is moved this should trigger
        {
            triggered = true;
        }

		if (Vector3.Distance(transform.position, player.transform.position) <= 3.00f)
		{
			triggered = true;
		}

	}

    public void Default()
    {
        triggered = false;
        transform.position = defaultposition;
    }
}
