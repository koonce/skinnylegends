using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
	private int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	private void FixedUpdate()
	{
		counter++;
		if (counter > 50)
		{
			Destroy(gameObject);
		}	}
}
