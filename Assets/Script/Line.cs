using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {
	public GameObject[] circles = new GameObject[2];
	private float distance;

	void Start () {
	}

	void Update () {
		GameObject left = circles[0];
		GameObject right = circles[1];

		transform.position = left.transform.position;

		distance = Vector2.Distance(left.transform.position, right.transform.position);
		transform.localScale = new Vector3(distance, 1, 1);

		Vector3 relativePos = right.transform.position - left.transform.position;
		Quaternion rot = Quaternion.LookRotation(relativePos, Vector3.back);
		rot = new Quaternion(0, 0, rot.z, rot.w);
		rot *= Quaternion.Euler(0, 0, 90);
		transform.rotation = rot;
	}
}
