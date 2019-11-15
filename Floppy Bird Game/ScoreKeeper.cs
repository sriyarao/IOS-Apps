using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreKeeper : MonoBehaviour {


	static int score = 0;
	static int highScore = 0;


	 public void AddPoint()
	{
		
		
		score++;


		if(score>highScore){
			highScore = score;


		}}


	void Start(){
		
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		if (player_go == null) {
			Debug.LogError ("Could not find an object with tag 'Player'.");
		}

		score = 0;
		highScore = PlayerPrefs.GetInt ("highScore", 0);
	}

	void OnDestroy() {
		PlayerPrefs.SetInt ("highScore", highScore);
	}

	// Use this for initialization
	void Update ()
	{
		Text scoreText = GetComponent<Text> ();
		scoreText.text = "Score: " + score.ToString () + "\nHigh Score: " + highScore.ToString();



		// Update is called once per frame

	}
}
