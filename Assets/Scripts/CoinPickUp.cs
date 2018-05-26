using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickUp : MonoBehaviour
{

	public Text Score;
	
	// Use this for initialization
	void Start ()
	{
		Score = GameObject.Find("Score").GetComponent<Text>();
	}
    
	private void OnTriggerEnter(Collider boxCollider)
	{
		if (boxCollider.name == "Car")
		{
			Score.text = (int.Parse(Score.text) + 1).ToString();
			
			Destroy(gameObject);
		}
	}
	
}
