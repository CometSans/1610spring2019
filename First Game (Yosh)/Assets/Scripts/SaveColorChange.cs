using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaveColorChange : MonoBehaviour
{

	public UnityEvent OnEvent;
	
	 void Update()
	{

	OnEvent.Invoke();
		
		
	}
}
