using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

	public GameObject invUI;
	public bool toggle;
	void Start () {
		toggle = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			toggle = !toggle;
			invUI.SetActive (toggle);

		}
	}
}
