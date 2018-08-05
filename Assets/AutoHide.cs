using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHide : MonoBehaviour {
	public float hideTime = 10;
	// Use this for initialization
	void Start () {
		StartCoroutine(Hide());
	}

    IEnumerator Hide(){
		yield return new WaitForSeconds(hideTime);
	}

}
