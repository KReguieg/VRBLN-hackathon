using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlashlightAndVideo : MonoBehaviour {

	public Light flashLight;
	private bool lightIsActivated = false;

	public Collider circleCollider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lightIsActivated){
			flashLight.enabled = true;
		}
		else{
			flashLight.enabled = false;
		}

	}

	private void OnTriggerEnter(Collider other)
    {
			Debug.LogWarning("LIGHT ON");
            lightIsActivated = true;
        
    }

	private void OnTriggerExit(Collider other)
    {
            lightIsActivated = false;

    }
}
