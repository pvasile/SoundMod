using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour 
{
	[SerializeField] Image customImage;

	void Update() {
		if (Input.GetKeyDown ("return")) {

			customImage.enabled = true;
		
		} if (Input.GetKeyUp ("return")) {

			customImage.enabled = false;
		}
	}
}

