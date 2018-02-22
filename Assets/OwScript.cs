using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

	public class OwScript : MonoBehaviour
	{
		[SerializeField] Image OwImage;

	void Start () 
	{
		OwImage.enabled = false;

	}

	void OnTriggerEnter (Collider other)
		{
		if(other.tag == "Player")
		{ 
			OwImage.enabled = true;
		}
			else { 
			OwImage.enabled = false;
	}
}
}