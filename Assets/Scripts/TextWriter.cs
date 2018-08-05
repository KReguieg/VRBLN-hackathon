using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour {

	public Text textBox;
     //Store all your text in this string array
	string[] goatText = new string[]{"Major Tom: 'Major Tom to Ground Control. Evacuation of foreign ship almost complete.", 
	"Major Tom: 'I am the last one on board. Will leave the ship at checkpoint Delta 5.' ",
	 "Ground Control: ' Ground Control to Major Tom. Negative. There's a meteor storm ahead of you. You need to get out right now!. ", 
	 "Ground Control: 'Don't worry, we'll talk you through this."};
	int currentlyDisplayingText = 0;
	void Awake () {
		StartCoroutine(AnimateText());
	}
		//This is a function for a button you press to skip to the next text
	public void SkipToNextText(){
		StopAllCoroutines();
		currentlyDisplayingText++;
		//If we've reached the end of the array, do anything you want. I just restart the example text
		if (currentlyDisplayingText>goatText.Length) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
		} else {
			StartCoroutine(AnimateText());
		}
	}
		//Note that the speed you want the typewriter effect to be going at is the yield waitforseconds (in my case it's 1 letter for every      0.03 seconds, replace this with a public float if you want to experiment with speed in from the editor)
	IEnumerator AnimateText(){
		if(currentlyDisplayingText < goatText.Length) {
			for (int i = 0; i < (goatText[currentlyDisplayingText].Length); i++)
			{
				textBox.text = goatText[currentlyDisplayingText].Substring(0, i);
				yield return new WaitForSeconds(.03f);
			}
		}

		Invoke("SkipToNextText", 2);
	}

}
