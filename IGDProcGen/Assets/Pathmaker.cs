using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using Random = UnityEngine.Random;

public class Pathmaker : MonoBehaviour {
    
    private int counter = 0;
    public Transform floorPrefab;
    public Transform pathmakerSpherePrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(counter < 50)
		{
			float ran = Random.Range(0, 1f);
			if (ran < .25f)
			{
				transform.Rotate(0,45,0);
				
				Debug.Log("rotating");
			}else if (ran < .5 && ran > .25)
			{
				transform.Rotate(0, 45, 0);
			}else if (ran >= .99f && ran <= 1.00f)
			{
				Instantiate(pathmakerSpherePrefab, transform.position,Quaternion.identity, null);
			}
			Debug.Log("forward");
			transform.Translate(transform.forward );
			Instantiate(floorPrefab, transform.position + Vector3.down, Quaternion.identity, null);
		}
		else
		{
			Destroy(this.gameObject);
		}
		counter++;

	}
}
