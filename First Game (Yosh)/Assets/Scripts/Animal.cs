﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
	public string Name;
	public int Health;
	public float Speed;
	public bool CanMove;
	
	public Color SkinColor; 
	//Write Event that changes a color and game variables HOMEWORK
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;

	}
	

	void Update () {
		
	}
}