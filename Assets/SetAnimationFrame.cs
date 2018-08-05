using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;
using VRTK.Controllables.ArtificialBased;

public class SetAnimationFrame : MonoBehaviour {
	public Animator animator;
	VRTK_ArtificialSlider slider;
	public float openess;
	// Use this for initialization
	void Start () {
		animator.speed = 0;
		slider = GetComponentInChildren<VRTK_ArtificialSlider>();
		slider.ValueChanged += ValueChanged;
	}

    private void ValueChanged(object sender, ControllableEventArgs e)
    {
        animator.Play("Default Take", -1 ,e.normalizedValue);
    }

}
