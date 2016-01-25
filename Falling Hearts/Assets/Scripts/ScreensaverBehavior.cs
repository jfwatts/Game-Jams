using UnityEngine;
using System.Collections;

public class ScreensaverBehavior : MonoBehaviour {

	float startTime;
	Vector3 lastMousePos;

	void Awake(){
		startTime = Time.time;
		lastMousePos = Input.mousePosition;
		Cursor.visible = false;
	}


	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > 3) {
			if (Input.anyKeyDown || (int)lastMousePos.x != (int)Input.mousePosition.x || (int)lastMousePos.y != (int)Input.mousePosition.y) {
				Application.Quit ();
			}
		}

		lastMousePos = Input.mousePosition;
	}
}
