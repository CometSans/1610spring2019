using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
	public string Name;
	public FloatData Health;
	public FloatData Speed;
	public bool CanMove;
	
	public Color SkinColor; 
	//Write Event that changes a color and game variables HOMEWORK
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;

	}
	

	void Update ()
	{
		if (!CanMove)
		{
			transform.Rotate(100,0,0);
		}	
	}
}
