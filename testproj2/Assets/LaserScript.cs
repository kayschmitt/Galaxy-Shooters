using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class LaserScript : MonoBehaviour {

	LineRenderer line;
	public Text scoreText;
	public Text strikeText;
	public static int currentHealth;
	public ParticleSystem explosion;
	public AudioSource shootingMusic;

	public GameOver overIt;


	public int scriptABool;
	public GameObject scriptAObject;


	//otherScript.DoSomething();

	public static int score;
	private int strike;
	//Animator anim;    



	void Start () 
	{
		
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
		//scriptAObject = Object.GetComponent<GameOver>();



		//anim = GetComponent <Animator> ();
		//Screen.lockCursor = true;
	}
	void Update () 
	{
		
		if(Input.GetButtonDown("Fire1"))
		{
		//	scriptAObject.StartCoroutine("FireLaser");
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
		//overScript.DoSomething ();
	}
	IEnumerator FireLaser()
	{
		
		//anim.SetTrigger ("GameOver");
		line.enabled = true;

		while (Input.GetButton ("Fire1")) {





			Ray ray = new Ray (transform.position, transform.forward);


			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			line.SetPosition(0, ray.origin);
			shootingMusic.Play ();


			if (Physics.Raycast (ray, out hit, 100)) {
				line.SetPosition (1, hit.point);
				if (hit.rigidbody) {
					if (hit.rigidbody.gameObject.GetComponent<Bad>()) {
						strike += 1;
						//if (strike == 3) {
							//StartCoroutine(quitApp());

						//}
						if (strike == 1) {
							strikeText.text = "X";
							currentHealth = 1;
						} 
						else if (strike == 2) {
							strikeText.text = "X X";
							currentHealth = 2;
						}
						else if (strike == 3) {
							strikeText.text = "X X X";
							currentHealth = 3;
							//StartCoroutine(quitApp());
							//anim.SetTrigger ("GameOver");
						}
					} 
					else {
						score += 10;
						scoreText.text = "Score: " + score;
					}

					ParticleSystem newExplos = Instantiate(explosion, hit.point, Quaternion.identity) as ParticleSystem;
					newExplos.Play();

					//play sound here 
					Destroy(hit.rigidbody.gameObject);

				}
			}
			else
				line.SetPosition(1, ray.GetPoint (100));
			


			yield return null;

		}

		line.enabled = false;
	}

	//IEnumerator quitApp()
	//{
		
	//	gameOver.text = "GAME OVER\nScore: " + score;
	//	yield return new WaitForSeconds(5);
	//	Application.Quit();
	//
}

