using UnityEngine;
using System;

public class Watchman : MonoBehaviour {

	public static bool isExit;
	public static int level;
	public static bool gameOver;
	void Start () {
		isExit = false;
		gameOver = false;

	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")) {
			if (transform.root.gameObject.name == "10(Clone)") {
				isExit = true;
				gameOver = true;
				Destroy (transform.parent.gameObject);
			} 
			else {
				level = Convert.ToInt32 (transform.root.gameObject.name.Substring (0, 1));
				PlayerPrefs.SetInt("Level", level);
				isExit = true;
				Destroy (transform.parent.gameObject);
			}
		}
	}
}
