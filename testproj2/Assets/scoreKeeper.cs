using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour {
	public static int score;
	Text scoreText;
	Text strikeText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent <Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score " + score;
	}
}
