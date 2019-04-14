using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
	public string Name;
	public FloatData Health;
	public FloatData Speed;
	public bool CanMove;
	public FloatData DamageLevel;
	public FloatData Level;
	
	public Color SkinColor; 
	//Write Event that changes a color and game variables HOMEWORK
	void Start ()
	{
		

	}
	

	void Update ()
	{
		if (!CanMove)
		{
			transform.Rotate(100, 0, 0);
		}
		else
		{
			transform.Rotate(10,0,0);
		}
		
	}
}
