﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {

    AudioSource audiosource;

    // Use this for initialization
    void Start () {

        audiosource = gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            audiosource.Play();
        }

    }



}
