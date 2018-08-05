using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGoalTrigger : MonoBehaviour {

	public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
    {
		//if(other == ball)
			Debug.LogWarning("WON");
        
    }

}
