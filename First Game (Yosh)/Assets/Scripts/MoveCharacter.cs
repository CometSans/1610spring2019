﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
	//Do not use Ridgid bodies with CharacterController
	//CharacterController only work with 3D physics
	public UnityEvent OnGrounded;
	
	public float Speed = 3;
	public float Gravity = -1;
	public float JumpForce = 30;
	
	public int Health;
	public float Ammo;
	public float Lives;
	
	
	private CharacterController _controller;
	private Vector3 position;
	
	void Start ()
	{
		_controller = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		if (_controller.isGrounded)
		{
			OnGrounded.Invoke();

		}

		if (_controller.isGrounded && Input.GetButton("Jump"))
		{
			position.y = JumpForce;
		}
		

		position.y += Gravity * Time.deltaTime;
		
		//if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
		{
			//position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
		}
		//else
		{
			//position.y = Gravity * Time.deltaTime;

		}
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

		
		_controller.Move(position);
	}
}
