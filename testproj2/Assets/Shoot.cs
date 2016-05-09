using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public Rigidbody BulletPrefab;
	public float Speed = 10;

	void Update()
	{
		if (Input.GetKey(KeyCode.D))
			Fire();
	}

	void Fire()
	{
		Rigidbody bullet = (Rigidbody) Instantiate(BulletPrefab, transform.position, transform.rotation);
		bullet.velocity = transform.forward * Speed;
	}
}
