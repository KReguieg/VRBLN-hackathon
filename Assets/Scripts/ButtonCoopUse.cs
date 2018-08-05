using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonCoopUse : MonoBehaviour {
	public GameEvent DoorButtonUseVR;
	public GameEvent DoorButtonUsePC;

	public UnityEvent Triiiiiger;

	public float Timing = 1;

	private void OnEnable() {
		DoorButtonUseVR.Listener += VREvent;
		DoorButtonUsePC.Listener += PCEvent;
	}

	private void OnDisable() {
		DoorButtonUseVR.Listener -= VREvent;
		DoorButtonUsePC.Listener -= PCEvent;
	}

	float VRtime = -1;
	float PCtime = -1;
	
	void VREvent(GameEvent e)
	{
		VRtime = Time.time;
	}

	void PCEvent(GameEvent e)
	{
		PCtime = Time.time;
	}

	void TriggerTrigger()
	{
		float Dist = Mathf.Abs(VRtime - PCtime);
		if(Dist <= Timing)
		 	Triiiiiger.Invoke();
	}
}
