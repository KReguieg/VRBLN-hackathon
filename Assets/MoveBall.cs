using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

	public float speed;
	private Rigidbody mRigidBody = null;
	// Use this for initialization
	void Start () {
		mRigidBody = GetComponent<Rigidbody> ();
	}
	
	Vector3 movement;
	// Update is called once per frame
	void FixedUpdate  () {
		if(Input.GetKey(KeyCode.A))
			movement = Vector3.left;
		if(Input.GetKey(KeyCode.D))
			movement = Vector3.right;
		if(Input.GetKey(KeyCode.W))
			movement = Vector3.up;
		if(Input.GetKey(KeyCode.S))
			movement = Vector3.down;
        mRigidBody.AddForce (movement * speed);
	}
}
