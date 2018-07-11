using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{

	public GameObject AI;

	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;
	
	
	// Use this for initialization
	private void Start ()
	{
		aiCount = CurrentLevel.AiCount;
		// begins coroutine - IEnumerator
		StartCoroutine(StartSpawn());

	}

	private IEnumerator StartSpawn()
	{
		while (true)
		{
			//Spawn, instantiate replicates a object
			//new AI will ref to new gameobject
			GameObject newAI = Instantiate(AI);
			// new AI can now access destination position
			newAI.GetComponent<AIMovement>().Destination = Destination;
			// counts down
			aiCount--;
			
			
			yield return new WaitForSeconds(CurrentLevel.Time);
		}
	}
	
	
		
	}

