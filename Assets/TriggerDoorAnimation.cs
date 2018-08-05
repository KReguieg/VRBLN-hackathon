using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorAnimation : MonoBehaviour {
    public Animator animator;

    // Use this for initialization
    void Start () {
		GetComponent<RiddleController>().riddleSolved += TriggerDoorAnim;
	}

    private void TriggerDoorAnim()
    {
		animator.SetTrigger("open_door");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
