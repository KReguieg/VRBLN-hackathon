using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMovement : MonoBehaviour {

	[SerializeField]
	private GameObject light;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			light.transform.position = transform.position;	
	}
}
