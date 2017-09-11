﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockWiseRotate : MonoBehaviour {

	private bool onTrigger = false;
	public GameObject hourHand;
	public GameObject minHand;

	public float minSpeed = 10.0f;
	public float hourSpeed = 10.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (hourHand.transform.eulerAngles.x -10 > 0 && Input.GetKeyDown ("return")) 
		{
			Debug.Log (hourHand.transform.eulerAngles.x);
			StartCoroutine (hourRotateRight ());
			StartCoroutine(minRotateRight());

		}
	}

	void OntriggerStay()
	{
		Debug.Log ("ontriggerStay");
		onTrigger = true;
	}

	void OnTriggerExit()
	{
		Debug.Log ("ontriggerExit");
		onTrigger = false;
	}

	IEnumerator minRotateRight()
	{
		for (int i = 0; i < 90; i++) 
		{
			minHand.transform.Rotate (new Vector3 (-4, 0, 0));
			yield return 0;
		}
	}

	IEnumerator hourRotateRight()
	{
		for (int i = 0; i < 90; i++) 
		{
			hourHand.transform.Rotate (new Vector3 (-1/3f, 0, 0));
			yield return 0;
		}
	}
}
