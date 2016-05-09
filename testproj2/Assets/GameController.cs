using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class GameController : MonoBehaviour {


	private float nextActionTime = 0.0f;
	public float period = 2.0f;
	public GameObject prefab;
	public GameObject prefab2;
	public GameObject prefab3;





	// Use this for initialization
	void Start () {
		StartCoroutine(addNew());
		StartCoroutine(addBad());
		StartCoroutine(addNew1());

	}
	
	// Update is called once per frame
	void Update () {
		

	}

	IEnumerator addNew()
	{
		while(true)
		{
			
			var number1 = Random.Range(-6,6);
			GameObject cube1 = Instantiate(prefab2, new Vector3(number1, 4, 0), Quaternion.identity) as GameObject;
			Rigidbody gameObjectsRigidBody = cube1.AddComponent<Rigidbody>();
			Destroy(cube1, 2.0f);
			//gameObjectsRigidBody.AddForce(0,0, -1, ForceMode.Impulse);
			yield return new WaitForSeconds(0.3F);
		}
	}

	IEnumerator addNew1()
	{
		while(true)
		{

			var number1 = Random.Range(-6,6);
			GameObject cube1 = Instantiate(prefab3, new Vector3(number1, 4, 0), Quaternion.Euler(0, 180, 0)) as GameObject;
			Rigidbody gameObjectsRigidBody = cube1.AddComponent<Rigidbody>();
			//gameObjectsRigidBody.AddForce(0,0, -1, ForceMode.Impulse);
			Destroy(cube1, 2.0f);
			yield return new WaitForSeconds(1.5F);
		}
	}


	IEnumerator addBad()
	{
		while(true)
		{
			var number1 = Random.Range(-6,6);
			GameObject cube1 = Instantiate(prefab, new Vector3(number1, 4, 0), Quaternion.identity) as GameObject;
			cube1.AddComponent<Bad>();
			Rigidbody gameObjectsRigidBody = cube1.AddComponent<Rigidbody>();
			Destroy(cube1, 2.0f);
			yield return new WaitForSeconds(2.0F);
		}
	}

}
