using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour {
	public GameObject[] target;

	public GameEventInt OrbitLeverMoved;
	Transform currentTarget;

	public float speed = 10;

	public GameEvent ShakeEvent;
	// Use this for initialization
	void Start () {
	}

	void OnEnable(){
		OrbitLeverMoved.Listener += OrbitChanged;
	}

	void OnDisable(){
		OrbitLeverMoved.Listener -= OrbitChanged;
	}

    private void OrbitChanged(GameEvent arg0)
    {
		currentTarget = target[(arg0 as GameEventInt).payload - 1].transform;
    }

    // Update is called once per frame
    void Update () {
		if(currentTarget != null)
			transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, speed * Time.deltaTime );
	}

	private void OnTriggerEnter(Collider other) {
		ShakeEvent.FireEvent();
	}
}
