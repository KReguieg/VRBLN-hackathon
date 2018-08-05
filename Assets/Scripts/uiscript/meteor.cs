using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour {
	public GameObject target;
	//public int speed;
	//public int yspeed;
	//public int zspeed;
	private Vector3 startpos;
	private int waiter = 0;
	float step =0;
	// Use this for initialization
	void Start () {
		startpos = transform.position;
		step = Random.Range(25,125) * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		// The step size is equal to speed times frame time.

		// Move our position a step closer to the target.
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		transform.Rotate (new Vector3 (0, Time.deltaTime * Random.Range(1,100), Time.deltaTime * Random.Range(1,100)));
		if(transform.position == target.transform.position){
			Debug.Log ("kutt");
			StartCoroutine (startmeteor());
		}
	}
		IEnumerator startmeteor(){
			yield return new WaitForSeconds (Random.Range(5,60));
			transform.position = startpos;
			
		}
		


}
