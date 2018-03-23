using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController Instance;

	void Awake() 
	{
		GameObject[] soundArray = GameObject.FindGameObjectsWithTag ("Music");
		if (soundArray.Length > 1) {
			Destroy (this.gameObject);
		}
		DontDestroyOnLoad (this.gameObject);
	}
}

