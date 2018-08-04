using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<RiddleController>().riddleSolved += TriggerOpenDoor;
	}

    private void TriggerOpenDoor()
    {
        GetComponent<Animator>().SetTrigger("open_door");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
