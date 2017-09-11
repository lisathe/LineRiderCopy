using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastEnemyScript : MonoBehaviour {


	public float EnemySpeed;
	private Rigidbody2D rb2d;

	public GameObject player;
	public GameObject FastEnemy;

	float minSpawnPositionX;
	float maxSpawnPositionX;
	float minSpawnPosY;
	float maxSpawnPosY;

	float objectTimer = 0f;
	float objectSpawnInterval = 5f;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		// this is for the wall tho 
		minSpawnPositionX = player.transform.position.x - 8f;
		maxSpawnPositionX = minSpawnPositionX - 3f;

		minSpawnPosY = 7f;
		maxSpawnPosY = -7f;

		if (objectTimer < objectSpawnInterval)
		{
			objectTimer += Time.deltaTime;
		}
		else
		{
			objectTimer = 0;
			SpawnObject();
		}


	}


	
	


	void SpawnObject()
	{

		Vector3 spawnPosition = new Vector3(Random.Range(minSpawnPositionX, maxSpawnPositionX), Random.Range(minSpawnPosY, maxSpawnPosY), 1);
		Instantiate(FastEnemy, spawnPosition, Quaternion.Euler(0, 180, 0));
        Debug.Log("mooiman");

	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player")
		{
			Destroy(gameObject);
			SceneManager.LoadScene("MainScene");
		}

		if (coll.gameObject.tag == "Obstacle")
		{
			Destroy(gameObject);
		}

		if (coll.gameObject.name == "DeathBlockPrefab")
		{
			Destroy(gameObject);
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
