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
	
	// Update is called once per frame
	void FixedUpdate  () {
		Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        mRigidBody.AddForce (movement * speed);
	}
}
