using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public GameObject helpText;
	public GameObject infoText;
	AudioSource audioSource;
	public Text textSound;
	bool isClicked;

	void Start () {
		isClicked = false;
		audioSource = GameObject.Find ("Sound").GetComponent<AudioSource> ();
	}

	public void ButtonStart () {
		SceneManager.LoadScene (1);
	}
	public void ButtonSound () {
		if (audioSource.isPlaying) {
			audioSource.Pause ();
			textSound.text = "Sound - On";
		} else {
			audioSource.Play ();
			textSound.text = "Sound - Off";
		}
	}
	public void ButtonHelp () {
		if (!isClicked) {
			isClicked = true;
			helpText.gameObject.SetActive (false);
			infoText.gameObject.SetActive (true);
			Invoke ("ReturnHelpText", 3);
		}
	}
	public void ButtonPatreon () {
		Application.OpenURL("https://www.patreon.com/hacivat");
	}
	public void ButtonQuit () {
		Application.Quit ();
	}
	public void Mail () {
		Application.OpenURL("mailto:pekaydin580@gmail.com");
	}

	void ReturnHelpText () {
		infoText.SetActive (false);
		helpText.SetActive (true);
		isClicked = false;
	}
}
