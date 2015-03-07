using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed;

	private Vector3 playerPos = new Vector3(0f, -3.17f, 0f);

	void FixedUpdate () {
	
		/*float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed * Time.deltaTime);
		playerPos = new Vector3 (Mathf.Clamp(xPos, -3.9f, 3.9f), -3.17f, 0f);
		transform.position = playerPos;*/

		transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * paddleSpeed * Time.deltaTime;
	}
}
