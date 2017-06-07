﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArrow : MonoBehaviour {

    
    public double distX, distY, moduloDist, uniX, uniY, time;
    

    // Use this for initialization
    void Start () {
        time = 0;

    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > 10)
        {
            Destroy(this.gameObject);
            time = 0;
        }
    }

    

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.gameObject.tag);

        if (coll.gameObject.tag == "Wall" || coll.gameObject.tag == "ShadowBox")
        {
            Destroy(this.gameObject);
        }
    }
}
