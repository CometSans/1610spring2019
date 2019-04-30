using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.U2D;

public class EnemyAI : MonoBehaviour
{
	public Transform Player;
	private NavMeshAgent agent;
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void OnTriggerStay(Collider other)
	{
		agent.destination = Player.position;
	}

	private void OnTriggerExit(Collider other)
	{
		agent.destination = transform.position;
	}
	
	
}
