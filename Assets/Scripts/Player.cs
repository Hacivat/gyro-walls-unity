using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody rigid;
	bool onPlatform = false;
	public float thrust;

	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}

	void Update () {
		//Jump ();
		//Thrust ();
		//Debug.Log (Platform.touchableUp + " " + Platform.touchableDown + " " + Platform.touchableRight + " " + Platform.touchableLeft);
	}

	void Jump () {
		if (Input.GetKeyDown(KeyCode.Space) && onPlatform) {
			rigid.AddForce (new Vector3 (0, 0.75f, 0), ForceMode.Impulse);
		}
	}

	void Thrust () {


		if (Controller.touchUp && Platform.touchableUp) {
			rigid.AddRelativeForce (-Vector3.forward * thrust, ForceMode.Impulse);
		}
		if (Controller.touchDown && Platform.touchableDown) {
			rigid.AddRelativeForce (Vector3.forward* thrust, ForceMode.Impulse);
		}
		if (Controller.touchRight && Platform.touchableRight) {
			rigid.AddRelativeForce (-Camera.main.transform.right* thrust, ForceMode.Impulse);
		}
		if (Controller.touchLeft && Platform.touchableLeft) {
			rigid.AddRelativeForce (Camera.main.transform.right* thrust, ForceMode.Impulse);
		}
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Platform") {
			onPlatform = true;
		}
	}

	void OnCollisionExit (Collision other) {
		if (other.gameObject.tag == "Platform") {
			onPlatform = false;
		}
	}
}
