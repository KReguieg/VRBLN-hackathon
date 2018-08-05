using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEverything : MonoBehaviour {

	public bool shake;
	public float speed = 50.0f; //how fast it shakes
	public float amount = 5.0f; //how much it shakes

	public List<GameObject> thingsToShake;
	public List<Vector3> originalObjPositions;

	public GameEvent ShakeEvent;

	private void OnEnable() {
		ShakeEvent.Listener += ShakeE;	
	}

	private void OnDisable() {
		ShakeEvent.Listener -= ShakeE;	
		
	}

    private void ShakeE(GameEvent obj)
    {
        shake = true;
    }
	private void Start() {
		originalObjPositions = new List<Vector3>();
		foreach(GameObject obj in thingsToShake){
				originalObjPositions.Add(obj.transform.position);
			}
	}

    void Update()
	{
		if(shake){
			foreach(var obj in thingsToShake){
				obj.transform.position = new Vector3(Mathf.Sin(Time.time * speed) * amount, obj.transform.position.y, obj.transform.position.z);
			}
		}
		else{
			int i = 0;
			foreach(var obj in thingsToShake){
				if(obj.transform.position != originalObjPositions[i]){
					obj.transform.position = originalObjPositions[i];
				}
			}

		}
		
		
	}
  
}
