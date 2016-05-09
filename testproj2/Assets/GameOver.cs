
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;




public class GameOver : MonoBehaviour
{
	//public PlayerHealth playerHealth;       // Reference to the player's health.
	public float restartDelay = 2f; 
	// otherScript: LaserScript = GetComponent(LaserScript); 
	public LaserScript playerHealth;
	public Text text1;
	public Button quitButton;


	Animator anim;                          // Reference to the animator component.
	float restartTimer;                     // Timer to count up to restarting the level


	void Start ()
	{
		

	
		// Set up the reference.
		anim = GetComponent <Animator> ();



			//GameObject thePlayer = GameObject.Find ("ShooterObj1");
			//LaserScript playerScript = thePlayer.GetComponent<LaserScript> ();
			//int score = playerScript.currentHealth;



	}


	void Update ()
	{
		

		//("FireLaser");
	
			int health = LaserScript.currentHealth;
			
		if (health == 3) {
			anim.SetTrigger ("GameOver");
			quitButton.onClick.AddListener( () => {quitFunc();} ); 
		

			//Scene scene = SceneManager.GetActiveScene(); 
			//ceneManager.LoadScene(scene.name);
			//Application.LoadLevel("Shooter");
			//UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);   
			//Application.LoadLevel("New State"); 
		}

			//scriptABool.ToString();


			//anim.SetTrigger("GameOver");

	}

	void quitFunc()
	{
		Application.Quit();
	}



}