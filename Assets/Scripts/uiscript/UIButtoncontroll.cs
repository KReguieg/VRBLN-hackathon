using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtoncontroll : MonoBehaviour {
	public GameObject viewBot;
	public GameObject viewTop;
	public GameObject viewLast;

	public GameObject MeteorUI;
	public GameObject MapUI;
	// Use this for initialization
	void Start () {
		activTop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void activTop(){
		viewBot.SetActive (false);
		viewTop.SetActive (true);
		viewLast.SetActive(false);
	}
	public void activBot(){
		viewBot.SetActive (true);
		viewTop.SetActive (false);
		viewLast.SetActive(false);

	}
	public void activMeteor(){
		MeteorUI.SetActive (true);
		MapUI.SetActive (false);
		viewLast.SetActive(false);

	}
	public void activMap(){
		MeteorUI.SetActive (false);
		MapUI.SetActive (true);
		viewLast.SetActive(false);

	}

	public void activeMaze(){
		MeteorUI.SetActive (false);
		MapUI.SetActive (false);
		viewLast.SetActive(true);

	}
}
