﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject o = GameObject.Find("GameCanvas");
        if (o != null)
        {
            o.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
