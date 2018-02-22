using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BangScript : MonoBehaviour {
	[SerializeField] Image bangImage;

	void Start() {

		bangImage.enabled = false;
	}


	void Update() {
		if (Input.GetKeyDown ("space")) {

			bangImage.enabled = true;

		} if (Input.GetKeyUp ("space")) {

			bangImage.enabled = false;
		}
	}
}