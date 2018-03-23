using UnityEngine;

public class Platform : MonoBehaviour {
	float rotationSpeed;
	float rotationRate;
	public static bool touchableUp;
	public static bool touchableDown;
	public static bool touchableLeft;
	public static bool touchableRight;


	void Start () {
		rotationRate = Values.rotationRate_;
		rotationSpeed = Values.rotationSpeed_;
		touchableUp = true;
		touchableDown = true;
		touchableLeft = true;
		touchableRight = true;
	}
	void Update () {
		RotatePlatform ();
		//Debug.Log ("X= " + transform.rotation.x + " Y= " + transform.rotation.y + " Z= " + transform.rotation.z); 
	} 


	void RotatePlatform () {
		if (Controller.touchUp && transform.rotation.x < rotationRate) {
			transform.Rotate (Time.deltaTime * rotationSpeed, 0f, 0f);
			touchableUp = true;
		} else {
			touchableUp = false;
		}

		if (Controller.touchDown && transform.rotation.x > -rotationRate) {
			transform.Rotate (Time.deltaTime * -rotationSpeed, 0f, 0f);
			touchableDown = true;
		} else {
			touchableDown = false;
		}

		if (Controller.touchRight && transform.rotation.z > -rotationRate) {
			transform.Rotate (0f, 0f, Time.deltaTime * -rotationSpeed);
			touchableRight = true;
		} else {
			touchableRight = false;
		}

		if (Controller.touchLeft && transform.rotation.z < rotationRate) {
			transform.Rotate (0f, 0f, Time.deltaTime * rotationSpeed);
			touchableLeft = true;
		} else {
			touchableLeft = false;
		}
	}
}
