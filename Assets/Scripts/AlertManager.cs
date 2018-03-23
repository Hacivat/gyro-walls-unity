using UnityEngine;

public class AlertManager : MonoBehaviour {

	public GameObject up;
	public GameObject down;
	public GameObject right;
	public GameObject left;

	void Update () {
		Alert ();
	}

	void Alert () {
		if (Controller.touchUp && !Platform.touchableUp) {
			up.gameObject.SetActive (true);
		} else {
			up.gameObject.SetActive (false);
		}
		if (Controller.touchDown && !Platform.touchableDown) {
			down.gameObject.SetActive (true);
		} else {
			down.gameObject.SetActive (false);
		}
		if (Controller.touchRight && !Platform.touchableRight) {
			right.gameObject.SetActive (true);
		} else {
			right.gameObject.SetActive (false);
		}
		if (Controller.touchLeft && !Platform.touchableLeft) {
			left.gameObject.SetActive (true);
		} else {
			left.gameObject.SetActive (false);
		}
	}

}
