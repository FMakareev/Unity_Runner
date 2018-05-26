using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{

	public Vector3 moveVector;
	
	public float Speed;

	public float TimeBeforDestroy;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, TimeBeforDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(moveVector * Time.deltaTime * Speed);
	}
}
