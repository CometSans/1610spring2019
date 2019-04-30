using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{

	public List<FloatData> CollectionList;
	
	
	
	public void Collect(FloatData obj)
	{
		CollectionList.Add(obj);
	}

	public void GoldfishInfo()
	{
		foreach (var obj in CollectionList)
		{
			if (obj.name == "Goldfish")
			{
				Debug.Log(obj.Value + " goldfish's.");
			}
		}
	}

	public void AmmoInfo()
	{
		foreach (var obj in CollectionList)
		{
			if (obj.name == "Ammo")
			{
				Debug.Log(obj.Value + " bullets.");
			}
		}
	}

	public void EnergyInfo()
	{
		for (int i = 0; i < 10; i++)
		{
			Debug.Log(i);
		}
	}
	
	
}
