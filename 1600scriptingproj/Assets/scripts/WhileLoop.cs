using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhileLoop : MonoBehaviour
{

	public Text DisplayText;

	public int i = 3;

	// Use this for initialization
	void Start ()
	{
         // 
		StartCoroutine(Ticker());

	}
	// type of code routine which enumerates
	IEnumerator Ticker()
	{
		
		while (i > 0)
		{
			DisplayText.text = i.ToString();
			
			//holds loop 
			yield return new WaitForSeconds(1);
			i--;
		}
		DisplayText.text = "Go!";
		yield return new WaitForSeconds(2);
		DisplayText.text = "";
	}

	private void Update()
	{
		
	}
}
