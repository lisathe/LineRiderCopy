﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollscript : MonoBehaviour {


    float scrollspeed = -10f;
    Vector2 startPos;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * scrollspeed, 20);
        transform.position = startPos + Vector2.right * newPos;
		
	}
}
