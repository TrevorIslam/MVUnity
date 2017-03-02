using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour {

	public GameObject rock;
	public GameObject[] invList;
	int counter;

	public class invObj {
		public string name;
		int amount;

		public invObj (string n, int q) {
			name = n;

			amount = q;
		}
	}

	public List<invObj> inv;

	public void AddToList (string n, int q) {
		inv.Add(new invObj(n,q));
	}

	void Start () {
		inv = new List<invObj> ();
		counter = 0;
	}

	void Update() {
		
	}
}