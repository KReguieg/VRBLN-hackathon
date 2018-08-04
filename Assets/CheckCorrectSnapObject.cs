using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CheckCorrectSnapObject : MonoBehaviour {

	public GameObject correctObjectToSnap;

	public Action correctObjectSnapped;

	// Use this for initialization
	void Start () {
		GetComponent<VRTK.VRTK_SnapDropZone>().ObjectSnappedToDropZone += CheckSnappedObject;
	}

    private void CheckSnappedObject(object sender, SnapDropZoneEventArgs e)
    {
        if(e.snappedObject == correctObjectToSnap)
		{
			if(correctObjectSnapped != null)
			{
				Debug.Log("Correct Pipe inserted.");
				correctObjectSnapped.Invoke();
			}
		}
    }



    // Update is called once per frame
    void Update () {
		
	}
}
