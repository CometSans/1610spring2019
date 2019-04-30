using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class UpdateBar : MonoBehaviour 
{

    private Image BarImage;
    public FloatData FillNumber;
    

	// Use this for initialization
	void Start ()
	{
		BarImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//cannot figure out where fillamount comes in
		//BarImage.fillAmount = FillNumber.Value;
	}
}
