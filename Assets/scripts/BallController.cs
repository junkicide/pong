using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	int Invert;
	public int TowardsPlayer = 1;


	// Use this for initialization
	void Start () {
	
		Invert = 1;
		TowardsPlayer = 1;

		GetComponent<Rigidbody>().velocity= new Vector3 (10.0f, -5.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -15.0f) {
			GameObject.Find ("Main Camera").GetComponent<Scores>().IncreaseScore (2);
			//enemy won
			respawn();
		}
		else if (transform.position.x > 15.0f) {
			GameObject.Find ("Main Camera").GetComponent<Scores>().IncreaseScore (1);
			//you won
			respawn();
		}
	}
	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.name == "wall") {
			Invert *= -1;
			GetComponent<Rigidbody>().velocity = new Vector3 (10.0f*TowardsPlayer, -5.0f* Invert , 0.0f);
		} else if (collision.gameObject.name == "me") {
			TowardsPlayer = 1;
			GetComponent<Rigidbody>().velocity = new Vector3 (10.0f*TowardsPlayer, -5.0f* Invert, 0.0f);
		}
		else if (collision.gameObject.name == "enemy") {
			TowardsPlayer = -1;
			GetComponent<Rigidbody>().velocity = new Vector3 (10.0f*TowardsPlayer, -5.0f* Invert , 0.0f);
		}
	}
	void respawn() {
		Start();
		transform.position = Vector3.zero;
	}
	}