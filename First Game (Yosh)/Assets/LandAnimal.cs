using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandAnimal : Animal
{

	public Color FeetColor;
	public Color TailColor;
	
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,100,0);	
	}
}
