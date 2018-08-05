using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageStepper : MonoBehaviour {


	public Sprite[] sprites;
	public float speed = 1;
	float timer = 0;
	Image image;
	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		number = Random.RandomRange(0,sprites.Length);
	}
	int number = 0;
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer >= 1/speed ){
			timer = 0;
			number = (number + 1) % sprites.Length ;
		}
		image.sprite = sprites[number];

	}
}
