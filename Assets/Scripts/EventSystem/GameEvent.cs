using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu()]
public class GameEvent : ScriptableObject {

	
	public System.Action<GameEvent> Listener;

	public void FireEvent(){
		if(Listener != null)
			Listener.Invoke(this);
	}

}
