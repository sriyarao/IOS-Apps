using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;

	public void AddPoint()
	{
		score++;


		if(score>highScore){
			highScore = score;


		}}

	// Use this for initialization
	void Update ()
	{
		Text scoreText = GetComponent<Text> ();
		scoreText.text = "Score: " + score.ToString () + "\nHigh Score: " + highScore.ToString();



		// Update is called once per frame

	}
}
