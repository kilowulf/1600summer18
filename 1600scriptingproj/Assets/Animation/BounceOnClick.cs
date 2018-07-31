﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOnClick : MonoBehaviour
{

	private Animator anims;

	private void Start()
	{
		anims = GetComponent<Animator>();
	}

	private void OnMouseDown()
	{
		anims.SetTrigger("canBounce");
	}

	private void OnTriggerEnter(Collider other)
	{
		anims.SetTrigger("canBounce");
	}

	public void EndAnims()
	{
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<SphereCollider>().enabled = false;
		GetComponent<ParticleSystem>().Emit(50);
	}
}
