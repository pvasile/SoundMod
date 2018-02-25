using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetect : MonoBehaviour {

	public Image OwImage;

	// Use this for initialization
	void Start () {

		OwImage.enabled = false;
		
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "BaseTank")
		{
			OwImage.enabled = true;


		} else {
			
			OwImage.enabled = false;

	}
}
}
