﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	public Sprite Active_Crystal;
	public Sprite Inactive_Crystal;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool checkpointReached;

	// Use this for initialization
	void Start () {
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D other)		{
	if (other.tag == "Player") {
			checkpointSpriteRenderer.sprite = Active_Crystal;
		checkpointReached = true;
		}
	}
}
