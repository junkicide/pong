using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	int Invert;
	public int TowardsPlayer = 1;

	// Use this for initialization
	void Start () {
		Invert = 1;
		TowardsPlayer = 1;
		GetComponent<Rigidbody>().velocity = new Vector3 (10.0f, -5.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3 (transform.position.x, ray.GetPoint(10f).y, transform.position.z);
	}
}
