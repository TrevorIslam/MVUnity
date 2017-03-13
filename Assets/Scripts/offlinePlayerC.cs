using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offlinePlayerC : MonoBehaviour {
	public GameObject rock;
	public GameObject stick;
	public GameObject grid;
	public GameObject hud;
	inventory inven;
	GameObject temprock;
	GameObject tempstick;

	void Start () {
		inven = this.GetComponent<inventory> ();
		temprock = GameObject.Find ("HUD/Panel/Rock");
		tempstick = GameObject.Find ("HUD/Panel/Stick");

		temprock.SetActive (false);
		tempstick.SetActive (false);
		GameObject.Find ("HUD/Panel").SetActive (false);
	}

	void Update () {
		if (hud.GetComponent<HUD>().toggle) {
			foreach(inventory.invObj thereisnopossiblewaythatanythingisnamedthis in inven.inv){
				

			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "stick") {
			CollideWithItem (other.gameObject);
			tempstick.SetActive (true);
		}
		if (other.gameObject.tag == "rock") {
			CollideWithItem (other.gameObject);
			temprock.SetActive (true);

		}


	}

	void CollideWithItem (GameObject tag) {
		inven.AddToList (tag.tag, 1);
		//temprock.transform.position = inven.invList[0].transform.position;

	}
}