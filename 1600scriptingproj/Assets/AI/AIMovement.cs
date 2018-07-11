using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// will attribute a NavMeshAgent component to object
[RequireComponent(typeof(NavMeshAgent))]
public class AIMovement : MonoBehaviour
{

	private NavMeshAgent Agent;
	
	// Transform is a Vector3 data type
	public Transform Destination;
	// ref to AIControl class
	public AIControl Control;
	
	// Use this for initialization
	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Agent.destination = Destination.position;
	}
	
	/* Remember to make plane or ground object static, object must be baked
	 *navigation > bake
	 * 
	 */
}
