﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastEnemyScript : MonoBehaviour {


	public float EnemySpeed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player")
		{
			Destroy(gameObject);
			SceneManager.LoadScene("MainScene");
		}
	}

	private void FixedUpdate()
	{
		float moveHorizontal = 1;
		float moveVertical = 0;

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		rb2d.AddForce(movement * EnemySpeed);


		if (rb2d.velocity.x > 10.02)
		{
			rb2d.velocity = rb2d.velocity.normalized * 11;
		}
	}

}
