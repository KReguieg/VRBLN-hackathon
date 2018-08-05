using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMainScene : MonoBehaviour {

	public string sceneToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeToMainTheme()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
	}
}
