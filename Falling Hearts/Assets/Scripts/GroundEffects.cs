using UnityEngine;
using System.Collections;

public class GroundEffects : MonoBehaviour {

	void OnParticleCollision(GameObject other){
		// Pause really quickly
		//Time.timeScale = 0.1f;


	}

	IEnumerator ScreenShake(){
		yield return new WaitForSeconds (0.01f);
		Time.timeScale = 1;
	}
}
