using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	GameObject startAt;
	public static GameObject currentMaze;
	public Text stage;
	public GameObject[] Mazes;
	public GameObject player;
	public Camera cam;
	public float[] camFieldofView;
	int level;

	void Awake () {
		level = PlayerPrefs.GetInt ("Level");
		Instantiate (Mazes[level]);
		startAt = GameObject.Find ("Start At");
		Instantiate (player, new Vector3(startAt.transform.position.x, startAt.transform.position.y, startAt.transform.position.z), Quaternion.identity);
		cam.fieldOfView = camFieldofView [level];	
	}

	void Update () {
		LevelUpdater ();
	}

	void LevelUpdater () {
			if (Watchman.isExit && !Watchman.gameOver) {
			Destroy (GameObject.Find("Player(Clone)"));
			stage.text = "stage " + (Watchman.level + 1).ToString ();
			stage.gameObject.SetActive (true);
			Invoke ("LevelStarter", 3);
			Watchman.isExit = false;
		}
			else if (Watchman.isExit && Watchman.gameOver) {
			Destroy (GameObject.Find("Player(Clone)"));
			stage.text = "the end";
			stage.gameObject.SetActive (true);
			Invoke ("ReturnToStart", 5);
		}
	}
	void LevelStarter () {
		stage.gameObject.SetActive (false);
		Instantiate (Mazes [PlayerPrefs.GetInt("Level")]);
		startAt = GameObject.Find ("Start At");
		Instantiate (player, new Vector3(startAt.transform.position.x, startAt.transform.position.y, startAt.transform.position.z), Quaternion.identity);
		cam.fieldOfView = camFieldofView [PlayerPrefs.GetInt("Level")];
	}

	void ReturnToStart () {
		stage.gameObject.SetActive (false);
		UnityEngine.SceneManagement.SceneManager.LoadScene (0);
	}
}
