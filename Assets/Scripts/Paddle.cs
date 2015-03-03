using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed;

	private Vector3 playerPos = new Vector3(0f, -3.17f, 0f);

	void Update () {
	
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed * Time.deltaTime);
		playerPos = new Vector3 (Mathf.Clamp(xPos, -4f, 4f), -3.17f, 0f);
		transform.position = playerPos;
	}
}
