﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditional : MonoBehaviour
{

    public UnityEvent OnEvent, OffEvent, PasswordEvent;
	public bool OnBool;
	public int Number = 11;
	public string Password;
	
	
	// Update is called once per frame
	void Update () 
	{
		if (OnBool)
		{
			OnEvent.Invoke();
		}
		else
		{
			OffEvent.Invoke();
		}

		if (Number >= 10)
		{
			print("Greater");
		}
		else
		{
			print("Lesser");
		}

		if (Password == "OU812")
		{
			PasswordEvent.Invoke();
		}
		else
		{
			print("Incorrect");
		}
		
		
	}
}
