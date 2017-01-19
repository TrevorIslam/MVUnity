using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offlinePlayerC : MonoBehaviour {
	public GameObject rock;
	public GameObject invUI;
	public GameObject hud;
	inventory inven;

	void Start () {
		inven = this.GetComponent<inventory> ();
	}

	void Update () {
		if (hud.GetComponent<HUD>().toggle) {
			foreach(inventory.invObj thereisnopossiblewaythatanythingisnamedthis in inven.inv){
				if (thereisnopossiblewaythatanythingisnamedthis.name == "Rock") {
					rock.SetActive (true);
				}
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "collectible") {
			inven.AddToList ("Rock", 1);
			Destroy (other.gameObject);

		}
	}
}