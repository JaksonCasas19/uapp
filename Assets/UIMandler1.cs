using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMandler1 : MonoBehaviour {
	public GameObject img;

	public void buttonEvent() {
		if (img.active) {
			img.SetActive (false);
		}else{
			img.SetActive (true);
	}
}
}