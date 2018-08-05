using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour {
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			moveship1 ();
		}
		if (Input.GetKey (KeyCode.S)) {
			moveship2();
		}
		if (Input.GetKey (KeyCode.D)) {
			moveship3();
		}
	}

	void moveship1(){
		float step = 50 * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target1.transform.position, step );
	}
	void moveship2(){
		float step = 50 * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target2.transform.position, step);
	}
	void moveship3(){
		float step = 50 * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target3.transform.position, step);
	}
}
