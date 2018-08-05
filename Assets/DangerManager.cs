using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerManager : MonoBehaviour {
	public GameObject CometPrefab;
	public List<Danger> dangers; 
	public Transform[] start;
	public Transform[] end;
	public float dangerSpeed = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	float time;
	// Update is called once per frame
	void Update () {
		time = Time.time;
		for (int i = 0; i < dangers.Count; i++)
		{
			if(!dangers[i].Remove && Mathf.Abs(Time.time - dangers[i].time * 60 ) <= 0.01f)
			{
				GameObject obj = Instantiate(CometPrefab, transform);
				obj.GetComponent<meteor>().transfromStart = start[dangers[i].Orbit - 1];
				obj.GetComponent<meteor>().transfromTarget = end[dangers[i].Orbit - 1];
				obj.GetComponent<meteor>().RandomSpeed = false;
				obj.GetComponent<meteor>().step = dangerSpeed;
				dangers[i].MarkToRemove();
			}
		}
		dangers.RemoveAll(x=>x.Remove);
	}

	[System.Serializable]
	public struct Danger{
		public int Orbit;
		public float time;

		public bool Remove;

		public void MarkToRemove(){
			Remove = true;
		}
	}
}
