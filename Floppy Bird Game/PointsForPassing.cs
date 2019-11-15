using UnityEngine;
using System.Collections;

public class PointsForPassing : MonoBehaviour {

	public birdMovement PlayerBird;

	public bool hasPassed;

	private ScoreManager theScore;

	// Use this for initialization
	void Start () {
		theScore = FindObjectOfType<ScoreManager> ();
		PlayerBird = FindObjectOfType<birdMovement> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (PlayerBird.transform.position.x > transform.position.x && !hasPassed) {
			theScore.scoreCounter += 1;
			hasPassed = true;
		}
	}
}
