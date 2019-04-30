using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterAnimal : Animal
{
	
	public Color FinColor;
	public FloatData Spit;
	
	
	
	// Use this for initialization
	void Start ()
	{
		newColor = Color.red;
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		

	}
}
