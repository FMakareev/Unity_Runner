using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter(Collider boxCollider)
	{
		Debug.Log("OnTriggerEnter!");
		if (boxCollider.name == "Car")
		{
			Debug.Log("Death!");
			Application.LoadLevel("GameOver");
			
		}
	}

}
