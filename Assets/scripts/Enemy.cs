using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public GameObject Ball;
	BallController ballController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if (Ball.transform.position.y > transform.position.y) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + 0.2f, transform.position.z);
			}
			if (Ball.transform.position.y < transform.position.y) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - 0.2f, transform.position.z);
			}

	}
}
