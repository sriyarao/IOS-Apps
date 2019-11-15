using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private Text theText;

	public int scoreCounter;


	// Use this for initialization
	void Start () {
		theText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		theText.text = "Score: " + scoreCounter;

	}
	public void ResetScore()
	{
		scoreCounter = 0;
	}

	public void AddScore(int scoreToAdd)
	{
		scoreCounter += scoreToAdd;
	}
}
