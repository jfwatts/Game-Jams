using UnityEngine;
using System.Collections;

public class ScreensaverBehavior : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
			Application.Quit();
	}
}
