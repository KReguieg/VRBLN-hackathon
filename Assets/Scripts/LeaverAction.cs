using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;
using VRTK.Controllables.ArtificialBased;

public class LeaverAction : MonoBehaviour {
	public GameEventInt LinkedAction;
	// Use this for initialization
	void Start () {
		GetComponentInChildren<VRTK_ArtificialRotator>().RestingPointReached += NewPosition;
		GetComponentInChildren<VRTK_ArtificialRotator>().MaxLimitReached += NewPosition;
		GetComponentInChildren<VRTK_ArtificialRotator>().MinLimitReached += NewPosition;
	}

    private void NewPosition(object sender, ControllableEventArgs e)
    {
        LinkedAction.payload = (int) e.value;
		LinkedAction.FireEvent();
    }
}
