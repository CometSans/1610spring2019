using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{

	public string CodeWord;
	public UnityEvent LightEvent;

	void Update()
	{
		if (CodeWord == "Wassup")
		{
			LightEvent.Invoke();
		}
	}
	
}
