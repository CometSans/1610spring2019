﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
	public UnityEvent PhysicalAttack, RangedAttack;
	
	public string Name;
	public FloatData Health;
	public FloatData Speed;
	public bool CanWalk;
	public FloatData DamageLevel;
	public bool CanShoot;

	protected Color newColor;
	
	public Color SkinColor;

	public void Move()
	{
		print("Move");
	}
	
	
	private void Start ()
	{
		

	}
	

	private void Update ()
	{
		if (!CanWalk)
		{
			PhysicalAttack.Invoke();
		}

		if (CanShoot)
		{
			RangedAttack.Invoke();
		}
		
	}
}
