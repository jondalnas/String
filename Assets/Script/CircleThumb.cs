using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleThumb : MonoBehaviour {

	void Start() {
	}

	void Update() {
	}

	public void onTouch(Collider2D c) {
		transform.position = c.transform.position;
	}
}
