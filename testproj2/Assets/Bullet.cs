using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private float spawnTime;

	void Start ()
	{
		spawnTime = Time.time;
	}

	void Update ()
	{
		if (Time.time >= spawnTime + 5)
		{
			gameObject.SetActive(false);
			Destroy(gameObject);
		}
	}


	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.gameObject.tag != "Player")
		{
			gameObject.SetActive(false);
			Destroy(gameObject);
		}        
	}
}