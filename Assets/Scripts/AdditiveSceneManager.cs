using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneManager : MonoBehaviour {

	public string[] ScenesToLoad;

	// Use this for initialization
	void Start () 
	{
		List<string> sceneNames = new List<string>();
		for(int i = 0; i < UnityEngine.SceneManagement.SceneManager.sceneCount; i++)
		{
			sceneNames.Add(UnityEngine.SceneManagement.SceneManager.GetSceneAt(i).name);
		}
		foreach (string  SceneName in ScenesToLoad)
		{
			if(!sceneNames.Contains(SceneName))
			{
				UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(SceneName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
			}
		}
	}
}
