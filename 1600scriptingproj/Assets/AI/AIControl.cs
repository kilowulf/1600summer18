using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIControl : ScriptableObject
{
	/*Control multiple AI's with single script
	 *
	 * 
	 */

	public float Speed;
	public float AngularSpeed;

	public void ConfigAI(NavMeshAgent agent)
	{
		// general speed
		agent.speed = Speed;
		
		// angular speed determines rotation speed
		agent.angularSpeed = AngularSpeed;
	}


}
