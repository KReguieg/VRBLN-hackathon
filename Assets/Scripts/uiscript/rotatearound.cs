using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatearound : MonoBehaviour {
	
	public GameObject centerpoint;
	public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (centerpoint.transform.position, new Vector3 (0, 0, 1), Time.deltaTime * speed);
	}
}
