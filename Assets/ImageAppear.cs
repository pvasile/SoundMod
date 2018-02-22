using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour 
{
	[SerializeField] Image customImage;

	void Update() {
		if (Input.GetKeyDown ("space")) {

			customImage.enabled = true;
		
		} if (Input.GetKeyUp ("space")) {

			customImage.enabled = false;
		}
	}
}

