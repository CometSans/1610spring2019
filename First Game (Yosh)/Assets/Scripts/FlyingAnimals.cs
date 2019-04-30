using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAnimals : Animal
{
	
	public Color WingColor;
	public FloatData Missile;

	
	// Use this for initialization
	void Start () 
	{
		newColor = Color.blue;
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
