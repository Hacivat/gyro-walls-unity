using UnityEngine;

public class Controller : MonoBehaviour {

	public static bool touchUp = false;
	public static bool touchDown = false;
	public static bool touchRight = false;
	public static bool touchLeft = false;

	public void UpTouchDown () {
		Platform.touchableUp = true;
		touchUp = true;
	}
	public void UpTouchUp () {
		touchUp = false;
	}
	public void DownTouchDown () {
		Platform.touchableDown = true;
		touchDown = true;
	}
	public void DownTouchUp () {
		touchDown = false;
	}
	public void RightTouchDown () {
		Platform.touchableRight = true;
		touchRight = true;
	}
	public void RightTouchUp () {
		touchRight = false;
	}
	public void LeftTouchDown () {
		Platform.touchableLeft = true;
		touchLeft = true;
	}
	public void LeftTouchUp () {
		touchLeft = false;
	}
}
