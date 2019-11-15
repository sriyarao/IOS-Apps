using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class birdMovement : MonoBehaviour {

	public string scene1;

	public float flapSpeed = 100f;
	float forwardSpeed = 1f;



	bool didFlap = false;

	public bool dead = false;
	float deathCooldown;

	Animator animator;

	public bool godMode = false;


	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
		if(animator==null){
		Debug.LogError ("Didn't find animator!");
	}
	
	}

	void Update(){


		if (dead) {


			
			deathCooldown -= Time.deltaTime;
		

			if (deathCooldown <= 0) 
			{

				if (Input.GetKeyDown (KeyCode.Space) && Input.GetKeyDown (KeyCode.Space)|| Input.GetMouseButtonDown (0) && Input.GetMouseButtonDown (0)) {


					SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);


				}
			}
		}
			else {
		

				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
					didFlap = true;
				}
			}
		}
		
	

	// Update is called once per frame
	void FixedUpdate () {

		if (dead)
			return;
		
		GetComponent<Rigidbody2D> ().AddForce (Vector2.right * forwardSpeed);

	
		if (didFlap) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * flapSpeed);
			animator.SetTrigger ("DoFlap");

			didFlap = false;
		}
		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {

			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D> ().velocity.y / 2));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	
	}


void OnCollisionEnter2D (Collision2D collision)
	{
		if (godMode) 
			return;
		
			dead = true;

		GetComponent<SpriteRenderer> ().enabled = true;



		}
	}

