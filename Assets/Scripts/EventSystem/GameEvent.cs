using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent", order = 0)]
public class GameEvent : ScriptableObject {
	public UnityEvent<GameEvent> Listener;

	public void FireEvent(){
		Listener.Invoke(this);
	}

}
