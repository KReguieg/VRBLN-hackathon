using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour {
	public Transform transfromTarget;
	public Transform transfromStart;

	public Vector3 target;
	//public int speed;
	//public int yspeed;
	//public int zspeed;
	public float step = 0;
	float rotationSpeed;
	public bool RandomSpeed = true;
	// Use this for initialization
	void Start () {
		if(transfromStart){
			transform.position = transfromStart.position;
		}
		if(transfromTarget)
		{
			target = transfromTarget.position;
		}
		if(RandomSpeed)
			step = Random.Range (25, 125) * Time.deltaTime;
		rotationSpeed = Random.Range (10, 50);
	}

	// Update is called once per frame
	void Update () {
		// The step size is equal to speed times frame time.

		// Move our position a step closer to the target.
		transform.position = Vector3.MoveTowards (transform.position, target, step);
		transform.Rotate (new Vector3 (0, 0, Time.deltaTime * rotationSpeed ));
		if (Vector3.Distance(transform.position, target ) <= 0.1f) {
			Destroy (gameObject);
		}
	}
}