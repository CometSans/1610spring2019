using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;

public class LandAnimal : Animal
{

	public Color ArmColor;
	public Color LegColor; 
	public UnityEvent Event;
	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,1,0);

	}
}
