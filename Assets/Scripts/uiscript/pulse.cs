using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale += new Vector3(Mathf.Sin(Time.time)*0.001f, Mathf.Sin(Time.time)*0.001f, Mathf.Sin(Time.time)*0.001f);
	}
}
