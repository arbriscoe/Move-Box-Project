using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private float _speed = 3.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(horizontalInput, 0, 0);
		Vector3 velocity = direction * _speed;
		transform.Translate(velocity * Time.deltaTime);
	}
}
