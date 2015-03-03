using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f;

	private Rigidbody rb;

	// Use this for initialization
	void Awake () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			transform.parent = null;
			rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
		}

	}
}
