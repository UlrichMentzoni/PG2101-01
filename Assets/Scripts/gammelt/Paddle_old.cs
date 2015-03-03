using UnityEngine;
using System.Collections;

public class Paddle_old : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0)
											* speed * Time.deltaTime;
		transform.position = new Vector3(Mathf.Clamp 
		                                 (transform.position.x, -4, 4), 0, 0);

	}
}
