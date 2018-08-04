using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu()]
public class GameEvent : ScriptableObject {

	
	public UnityEvent<GameEvent> Listener;

	public void FireEvent(){
		Listener.Invoke(this);
	}

}
