﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaveColorChange : MonoBehaviour
{

	public UnityEvent SaveColorChangeEvent;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		SaveColorChangeEvent.Invoke();
		
	}
}