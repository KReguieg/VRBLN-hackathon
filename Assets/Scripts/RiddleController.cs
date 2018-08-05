using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RiddleController : MonoBehaviour {

	public CheckCorrectSnapObject[] snapDropZones;
    private int riddleScore = 0;

	public Action riddleSolved;

    // Use this for initialization
    void Start () {
		foreach (var snapDropZone in snapDropZones)
		{
			snapDropZone.correctObjectSnapped += IncreaseRiddleScore;
		}
	}

    private void IncreaseRiddleScore()
    {
        riddleScore++;

		CheckSuccsess();
    }

    // Update is called once per frame
    void CheckSuccsess () {
		if(riddleScore >= snapDropZones.Length)
		{
			Debug.Log("Riddle solved!");
			if(riddleSolved != null)
				riddleSolved.Invoke();
		}
	}
}
