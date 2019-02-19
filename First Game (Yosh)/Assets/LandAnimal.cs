using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;

public class LandAnimal : Animal
{

	public Color FeetColor;
	public float EatingSpeed = 0.4f;
	public bool CanEat = true;
	public UnityEvent Event; 
	
	
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
