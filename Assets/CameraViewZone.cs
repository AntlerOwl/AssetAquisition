﻿using UnityEngine;
using System.Collections;

public class CameraViewZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("I'm being seen by the Camera!");
        }          
       
    }
}
