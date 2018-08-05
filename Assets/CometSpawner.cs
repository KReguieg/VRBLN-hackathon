using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometSpawner : MonoBehaviour {


	public GameObject Comet;

	public float minInterval, maxInteval;
	float timer = 0;
	float currentInterval;

	public GameObject[] start;
	public GameObject[] finish;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > currentInterval)
		{
			CreateComet();
			currentInterval = Random.Range(minInterval, maxInteval);
			timer = 0;
		}
	}

	void CreateComet()
	{
		GameObject comet =  Instantiate(Comet, transform);
		comet.GetComponent<meteor>().transform.position = LerpPos(start);
		comet.GetComponent<meteor>().target = LerpPos(finish);
		

	}

	Vector3 LerpPos(GameObject[] ar)
	{
		return Vector3.Lerp(ar[0].transform.position, ar[1].transform.position , Random.value);
	}
}
