using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTouch : MonoBehaviour {
	public float fingerRadius = 1.5f;

	void Start() {
	}

	void Update() {
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.touches[i];

			//if (touch.phase != TouchPhase.Moved) continue;
			
			foreach (Collider2D c in Physics2D.OverlapCircleAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), fingerRadius)) {
				Debug.Log("hi");
				c.gameObject.SendMessage("onTouch", c);
			}
		}

		foreach (Collider2D c in Physics2D.OverlapCircleAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), fingerRadius)) {
			if (c.GetComponents<CircleThumb>().Length == 0) continue;

			c.GetComponent<CircleThumb>().onTouch(c);
		}
	}
}
