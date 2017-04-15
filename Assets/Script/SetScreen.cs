using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScreen : MonoBehaviour {
	public static bool hasMultiTouch;

	void Start() {
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = false;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;

		hasMultiTouch = Input.multiTouchEnabled;
	}
}
